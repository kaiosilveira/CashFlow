﻿using System;

namespace CashFlow.Domain.Model.Entities
{
    public abstract class Transaction
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
