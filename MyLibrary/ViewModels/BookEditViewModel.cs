﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
    public class BookEditViewModel
    {
        public Book Book { get; set; }

        public List<SelectListItem> Libraries { get; set; }

        public BookEditViewModel(ApplicationDbContext context)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();
        }

        //Created this computer to re-display the form with submitted values already populated in the form.
        //Used this to POST Method for EDIT.
        public BookEditViewModel(ApplicationDbContext context, Book book)
        {
            Libraries = context.Library.Select(library =>
            new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();
            Book = book;
        }
    }
}
