﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Albina.DataAccessCore.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.DataAccessCore.Models
{
    [Table("User")]
    public class UserRto
    {
        #region Главные поля
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required] public string PhoneNumberPrefix { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required, MinLength(7)]public string Password { get; set; }
        public string ImageName { get; set; }
        #endregion
        #region Внешнии ключи
        public List<VirtualExpenseRto> VirtualExpenses { get; set; }
        public List<RejectExpenseRto> RejectExpenses { get; set; }
        public List<AcceptExpenseRto> AcceptExpenses { get; set; }
        #endregion
    }
}
