using FluentValidation;
using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public interface IOperatorController : IBaseController<Operator>, IBaseValidatorController<Operator>
   {
      Operator GetByID(object id);
      Operator GetByLoginID(string id);
      //int UpdatePassword(Operator obj);
      //int UpdatePassword(Operator obj, ref ValidationError validationError);
      bool LoginIDIsUnique(string loginID, int currentID = default(int));
      bool ValidateOperator(string loginID, string password);
      bool Login(Operator obj, ref ValidationError validationError);
   }

   public class OperatorController : IOperatorController
   {

      #region >> Fields <<

      private IOperatorRepository _repository;
      private OperatorValidator _validator;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public OperatorController()
      {
         _validator = new OperatorValidator(this);
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Operator> GetAll()
      {
         IList<Operator> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            listObj = _repository.GetAll();
         }

         return listObj;
      }

      public Operator GetByID(object id)
      {
         Operator obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            obj = _repository.GetByID(id);
         }

         return obj;
      }

      public Operator GetByLoginID(string id)
      {
         Operator obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            obj = _repository.GetByLoginID(id);
         }

         return obj;
      }

      public int Save(Operator obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            obj.password = PasswordHash.CreateHash(obj.password);
            result = _repository.Save(obj);
         }

         return result;
      }

      public int Save(Operator obj, ref ValidationError validationError)
      {
         var result = _validator.Validate(obj);

         if (!result.IsValid)
         {
            foreach (var error in result.Errors)
            {
               validationError.PropertyName = error.PropertyName;
               validationError.Message = error.ErrorMessage;
            }

            return 0;
         }

         return Save(obj);
      }

      public int Update(Operator obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);

            // Jika user tidak memasukkan / tidak mengubah password
            // maka set kembali password dengan password yang lama
            if (string.IsNullOrWhiteSpace(obj.password))
            {
               Operator objTemp = _repository.GetByID(obj.id);
               obj.password = objTemp.password;
            }
            else
               obj.password = PasswordHash.CreateHash(obj.password);

            result = _repository.Update(obj);
         }

         return result;
      }

      public int Update(Operator obj, ref ValidationError validationError)
      {
         var result = _validator.Validate(obj);

         if (!result.IsValid)
         {
            foreach (var error in result.Errors)
            {
               validationError.PropertyName = error.PropertyName;
               validationError.Message = error.ErrorMessage;
            }

            return 0;
         }

         return Update(obj);
      }

      public int Delete(Operator obj)
      {
         var result = 0;

         if (obj == null)
         {
            throw new NullReferenceException("Object yang ingin dihapus tidak bisa null.");
         }

         if (obj.id == 1 || obj.login_id.Equals("admin")) return -1;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            result = _repository.Delete(obj);
         }

         return result;
      }

      public bool ValidateOperator(string loginID, string password)
      {
         Operator obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            obj = _repository.GetByLoginID(loginID);
         }

         if (obj != null && PasswordHash.ValidatePassword(password, obj.password))
         {
            return true;
         }

         return false;
      }

      //public int UpdatePassword(Operator obj)
      //{
      //   var result = 0;

      //   using (IDapperContext context = new DapperContext())
      //   {
      //      _repository = new OperatorRepository(context);
      //      obj.password = PasswordHash.CreateHash(obj.password);
      //      result = _repository.UpdatePassword(obj);
      //   }

      //   return result;
      //}

      //public int UpdatePassword(Operator obj, ref ValidationError validationError)
      //{
      //   var passValidator = new PasswordValidator(this);
      //   var result = passValidator.Validate(obj);

      //   if (!result.IsValid)
      //   {
      //      foreach (var error in result.Errors)
      //      {
      //         validationError.PropertyName = error.PropertyName;
      //         validationError.Message = error.ErrorMessage;
      //      }

      //      return 0;
      //   }

      //   return UpdatePassword(obj);
      //}

      public bool LoginIDIsUnique(string loginID, int currentID = default(int))
      {
         Operator obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new OperatorRepository(context);
            obj = _repository.GetByLoginID(loginID);
         }

         if (obj == null || obj.id == currentID)
         {
            return true; // unique
         }

         return false;
      }

      public bool Login(Operator obj, ref ValidationError validationError)
      {
         var loginValidator = new LoginValidator(this);
         var result = loginValidator.Validate(obj);

         if (!result.IsValid)
         {
            foreach (var error in result.Errors)
            {
               validationError.PropertyName = error.PropertyName;
               validationError.Message = error.ErrorMessage;
            }

            return false;
         }

         return true;
      }

      #endregion

   }
   
   public class OperatorValidator : AbstractValidator<Operator>
   {
      public OperatorValidator(IOperatorController controller)
      {
         CascadeMode = CascadeMode.StopOnFirstFailure;

         // role_kode
         RuleFor(o => o.role_kode)
            .NotEmpty()
            .WithMessage(ErrorMessage.NotSelected.Replace("{PropertyName}", "Role")); // Role belum dipilih oleh user
         // Berlaku ketika password tidak kosong,
         // konfirmasi password harus sama dengan password
         When(o => !string.IsNullOrEmpty(o.password), () =>
         {
            // konf_password
            RuleFor(o => o.konf_password)
               .NotEmpty().WithMessage(ErrorMessage.NotEmpty)
               .Equal(o => o.password)
               .WithMessage("Maaf, 'Password konfirmasi' yang anda masukan salah !!!");
         });
         // Berlaku ketika menambhakan data baru,
         // password tidak boleh kosong
         When(o => o.id == default(int), () =>
         {
            // password
            RuleFor(o => o.password)
               .NotEmpty().WithMessage(ErrorMessage.NotEmpty)
               .Length(3, 30).WithMessage(ErrorMessage.MaxMinLength);
         });
         // login_id
         RuleFor(o => o.login_id)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty)
            .Length(3, 30).WithMessage(ErrorMessage.MaxMinLength)
            .Matches(@"^[a-zA-Z0-9_]+$")
            .WithMessage("Maaf, Hanya karakter Abjad, Huruf dan "
            + "Underscore yang diijinkan untuk Login ID !!!");
         RuleFor(o => o)
            .Must(o => controller.LoginIDIsUnique(o.login_id, o.id)) // Login id harus unique
            .WithMessage("Maaf, 'Login ID' yang anda masukkan sudah digunakan." +
            "Silahkan coba dengan 'Login ID' yang lain !!!");
         // hp
         RuleFor(o => o.hp)
            .MaximumLength(20).WithMessage(ErrorMessage.MaxLength);
         // alamat
         RuleFor(o => o.alamat)
            .MaximumLength(150).WithMessage(ErrorMessage.MaxLength);
         // nama
         RuleFor(o => o.nama)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty)
            .Length(3, 100).WithMessage(ErrorMessage.MaxMinLength);
      }
   }

   public class PasswordValidator : AbstractValidator<Operator>
   {
      public PasswordValidator(IOperatorController controller)
      {
         CascadeMode = CascadeMode.StopOnFirstFailure;

         // konf_password
         RuleFor(o => o.konf_password)
            .NotEmpty()
            .WithMessage(ErrorMessage.NotEmpty)
            .Equal(o => o.password)
            .WithMessage(ErrorMessage.WrongInput);
         // password
         RuleFor(o => o.password)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty.Replace("{PropertyName}", "Password baru"))
            .Length(3, 30).WithMessage(ErrorMessage.MaxMinLength.Replace("{PropertyName}", "Password baru"));
         // Berlaku ketika password sekarang tidak kosong
         When(o => !string.IsNullOrWhiteSpace(o.current_password), () =>
         {
            // Password sekarang dan password baru tidak boleh sama
            RuleFor(o => o.current_password)
            .NotEqual(o => o.password)
            .WithMessage("Maaf, 'Password sekarang' dan 'Password baru' tidak boleh sama !!!");
            // Password sekarang harus sama dengan hashed password
            RuleFor(o => o)
            .Must(o => PasswordHash.ValidatePassword(o.current_password, o.current_hashed))
            .WithMessage(ErrorMessage.WrongInput.Replace("{PropertyName}", "Password sekarang"));
         });
         // current_password
         RuleFor(o => o.current_password)
            .NotEmpty()
            .WithMessage(ErrorMessage.NotEmpty);
      }
   }

   public class LoginValidator : AbstractValidator<Operator>
   {
      public LoginValidator(IOperatorController controller)
      {
         CascadeMode = CascadeMode.StopOnFirstFailure;

         RuleFor(o => o)
            .Must(o => controller.ValidateOperator(o.login_id, o.password))
            .WithMessage("Maaf, Login ID atau Password yang anda masukkan salah !!!");
         // password
         RuleFor(o => o.password)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty);
         // login_id
         RuleFor(o => o.login_id)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty);
      }
   }

}
