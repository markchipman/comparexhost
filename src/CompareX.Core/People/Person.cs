﻿using Abp.Domain.Entities.Auditing;
using CompareX.PhoneNumber;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompareX.People
{
    [Table("AppPersons")]
    public class Person : AuditedEntity<Guid>
    {
        public const int MaxNameLength = 32;
        public const int MaxSurnameLength = 32;
        public const int MaxEmailAddressLength = 255;

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxSurnameLength)]
        public string Surname { get; set; }

        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }
    }    
}
