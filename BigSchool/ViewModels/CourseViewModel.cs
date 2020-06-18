﻿using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BigSchool.ViewModels;
using System.Globalization;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Requied]
        public string Place { get; set; }
        [Requied]
        [FutureDate]
        public string Date { get; set; }
        [Requied]
        [ValidTime]
        public string Time { get; set; }
        [Requied]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}