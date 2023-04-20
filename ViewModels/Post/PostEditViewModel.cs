using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Programming_Assignment_2021.Models;

namespace Web_Programming_Assignment_2021.ViewModels.Post
{
    public class PostEditViewModel
    {
        public Models.Post PostToBeEdited { get; set; }

        public bool SuccessMessageVisible { get; set; }
        public bool ErrorMessageVisible { get; set; }
    }
}
