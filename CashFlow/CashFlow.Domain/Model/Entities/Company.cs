﻿using System.Collections.Generic;

namespace CashFlow.Domain.Model.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FantasyName { get; set; }
        public string Register { get; set; }

        public IList<Project> Projects { get; set; }
        public IList<Income> Incomes { get; set; }
        public IList<Cost> Costs { get; set; }
    }
}
