﻿using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
       
    }
}