using CashFlow.Domain.Contracts.Interfaces;
using CashFlow.Domain.Model.Entities;
using CashFlow.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashFlow.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        // GET: Company
        public ActionResult Index()
        {
            var model = new CompanyModel()
            {
                Companies = companyRepository.List().ToList()
            };

            return View(model);
        }

        public ActionResult CreateOrEdit(int? id)
        {
            var model = new CompanyCreateOrEditModel();

            if (id.HasValue && id.Value != 0)
            {
                var company = companyRepository.Get(id.Value);
                model.Id = id.Value;
                model.Name = company.Name;
                model.Register = company.Register;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateOrEdit(CompanyCreateOrEditModel model)
        {
            if(ModelState.IsValid)
            {
                var company = new Company()
                {
                    Id = model.Id,
                    Name = model.Name,
                   FantasyName = model.FantasyName,
                    Register = model.Register
                };
                
                if (model.Id != 0)
                    companyRepository.Update(company);
                else
                    companyRepository.Create(company);

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Details(int id)
        {
            var company = companyRepository.Get(id);
            var model = new CompanyDetailsModel()
            {
                Id = company.Id,
                Name = company.Name,
                FantasyName = company.FantasyName,
                Register = company.Register
            };

            return View(model);
        }
    }
}