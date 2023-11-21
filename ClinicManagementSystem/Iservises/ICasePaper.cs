using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicManagementSystem.Iservises
{
    public interface ICasePaper
    {
        List<tblCasePaper> GetAll();

        tblCasePaper Findbyid(int id);



        string Save(tblCasePaper obj);

        bool Delete(int id);

        dynamic GetAllkey(string key);


        dynamic GetAllPage(int pagno);
    }
}