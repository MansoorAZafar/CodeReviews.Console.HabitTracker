﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHabitTracker.kraven88.Models;
internal class Habit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<DailyProgress> ProgressList { get; set; }
}
