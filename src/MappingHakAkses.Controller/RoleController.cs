using FluentValidation;
using MappingHakAkses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingHakAkses.Controller
{
   public interface IRoleController : IBaseController<Role>, IBaseValidatorController<Role>
   {
      Role GetByID(object id);
      bool KodeIsUnique(string kode, int currentID = default(int));
      bool NamaIsUnique(string kode, int currentID = default(int));
   }

   public class RoleController : IRoleController
   {

      #region >> Fields <<

      private IRoleRepository _repository;
      private RoleValidator _validator;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public RoleController()
      {
         _validator = new RoleValidator(this);
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      public IList<Role> GetAll()
      {
         IList<Role> listObj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            listObj = _repository.GetAll();
         }

         return listObj;
      }

      public Role GetByID(object id)
      {
         Role obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            obj = _repository.GetByID(id);
         }

         return obj;
      }

      public int Save(Role obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            result = _repository.Save(obj);
         }

         return result;
      }

      public int Save(Role obj, ref ValidationError validationError)
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

      public int Update(Role obj)
      {
         var result = 0;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            result = _repository.Update(obj);
         }

         return result;
      }

      public int Update(Role obj, ref ValidationError validationError)
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

      public int Delete(Role obj)
      {
         var result = 0;

         if (obj == null)
         {
            throw new NullReferenceException("Object yang ingin dihapus tidak bisa null.");
         }

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            result = _repository.Delete(obj);
         }

         return result;
      }

      public bool NamaIsUnique(string nama, int currentID = default(int))
      {
         Role obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            obj = _repository.GetByNama(nama);
         }

         if (obj == null || obj.id == currentID)
         {
            return true; // unik
         }

         return false;
      }

      public bool KodeIsUnique(string kode, int currentID = default(int))
      {
         Role obj = null;

         using (IDapperContext context = new DapperContext())
         {
            _repository = new RoleRepository(context);
            obj = _repository.GetByKode(kode);
         }

         if (obj != null && obj.id != currentID)
         {
            return false;
         }
         else if (obj == null || obj.id == currentID)
         {
            return true; // unik
         }

         return false;
      }

      #endregion

   }

   public class RoleValidator : AbstractValidator<Role>
   {
      public RoleValidator(IRoleController controller)
      {
         CascadeMode = CascadeMode.StopOnFirstFailure;

         // created_by
         RuleFor(r => r.created_by)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty);
         // keterangan
         RuleFor(r => r.keterangan)
            .MaximumLength(150).WithMessage(ErrorMessage.MaxLength);
         // nama
         RuleFor(r => r.nama)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty)
            .Length(3, 100).WithMessage(ErrorMessage.MaxMinLength);
         // kode
         RuleFor(r => r.kode)
            .NotEmpty().WithMessage(ErrorMessage.NotEmpty)
            .Length(2, 20).WithMessage(ErrorMessage.MaxMinLength);
         // unik
         RuleFor(r => r)
            .Must(r => controller.NamaIsUnique(r.nama, r.id)) // Nama role harus unik
            .WithMessage(ErrorMessage.NotUnique.Replace("{PropertyName}", "Nama"));
         RuleFor(r => r)
            .Must(r => controller.KodeIsUnique(r.kode, r.id)) // Kode role harus unik
            .WithMessage(ErrorMessage.NotUnique.Replace("{PropertyName}", "Kode"));
      }
   }
}
