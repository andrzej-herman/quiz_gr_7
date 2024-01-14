﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Answer
    {
        public int DisplayOrder { get; set; }
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}
