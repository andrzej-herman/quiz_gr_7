﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public static class QuestionCreator
    {
        public static List<Question> GetQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var data = File.ReadAllText(path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true }; 
            return JsonSerializer.Deserialize<List<Question>>(data, options);
        }
    }
}
