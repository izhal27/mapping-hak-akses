# Mapping Hak akses

Mapping Hak akses user padad control Button, MenuStrip dan ToolStrip WinForms.

## Getting Started

Idenya saya dapatkan dari artikelnya om **Rully Yulian Muhammad Firmansyah** [Mapping Hak Akses User Pada MenuStrip Sampai Control Button](http://www.yulianmf.com/Mapping-Hak-Akses-User-Pada-MenuStrip-Sampai-Control-Button.aspx), disini saya hanya mengubahnya ke dalam C# menggunakan ORM Dapper, menambahkan kolom menu_parent pada tabel role_detail, ComboBox Menu pada form hak akses dan menambahkan perintah untuk melewati control yang diset ignore/tidak ingin di masukan ke dalam list hak akses.

---

Dibawah ini adalah beberapa value yang harus diterapkan pada property [MenuStrip](#menustrip "Goto menustrip"), [ToolStrip](#toolstrip "Goto toolstrip"), 
[Form](#form "Goto form"), dan [Button](#button "Goto button").  


## MenuStrip 

Property                      | Value                  | Keterangan
----------------------------- | ---------------------- | ----------------------------------------------------------------------------------
AccessibleDescription         | (MenuParent name)      | Diisi dengan nama menu parent pada MenuStrip *(Abaikan jika Tag value ignore)*
AccessibleName                | menu                   | Jika menu/sub menu item hanya sebagai menu biasa *(Abaikan jika Tag value ignore)*
.                             | menuForm               | Jika menu/sub menu item digunakan untuk menampilkan sebuah Form
Tag                           | (Form name)            | Nama form yang ingin ditampilkan oleh sub menu
.                             | ignore                 | Jika menu item tidak ingin dimasukan dalam list hak akses

## ToolStrip

ToolStrip button biasanya hanyalah sebuah shortcuts dari sub menu di MenuStrip yang digunakan yang menampilkan sebuah form.

Property                      | Value                  | Keterangan
----------------------------- | ---------------------- | -----------------------------------------------------------------------------------------------
AccessibleDescription         | (MenuParent name)      | Diisi dengan nama menu parent pada MenuStrip *(Abaikan jika Tag value ignore)*
AccessibleName                | menuForm               | ToolStrip button yang digunakan untuk menampilkan sebuah Form *(Abaikan jika Tag value ignore)*
Tag                           | (Form name)            | Nama form yang ingin ditampilkan oleh ToolStrip button 
.                             | ignore                 | Jika ToolStrip button tidak ingin dimasukan dalam list hak akses

## Form

Property                      | Value                  | Keterangan
----------------------------- | ---------------------- | ------------------------------------------------------------------------------
AccessibleName                | (MenuParent name)      | Diisi dengan nama menu parent pada MenuStrip *(Abaikan jika Tag value ignore)*
Tag                           | ignore                 | Jika Form tidak ingin dimasukan dalam list hak akses

## Button

Property                      | Value                  | Keterangan
----------------------------- | ---------------------- | ----------------------------------------------------------------
Tag                           | (Button text)          | Jika anda menggunakan tanda shortcuts "&" pada Button text anda
.                             | ignore                 | Jika Button tidak ingin dimasukan dalam list hak akses

---

### Prerequisites

Library yang dibutuhkan

* .NET Framework 4.5
* MySql Connector

### User default

User ID   | Password
--------- | --------
admin     | admin
op1       | op1
op2       | op2
op3       | op3

## Authors

* **Risal Walangadi** - *Initial work* - [izhal27](https://github.com/izhal27)

## License

This project is licensed under the MIT - see the [LICENSE](LICENSE.MD) file for details

## Acknowledgments

* Allah SWT
* Prophet Muhammad SAW
* My Parents
* Om Rully Yulian Muhammad Firmansyah
* Om Abu anas - [k4m4r82](https://github.com/k4m4r82)