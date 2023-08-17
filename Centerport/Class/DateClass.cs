using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Class
{
  public  class DateClass
    {

      public static string getAge(string bdate)
      {
          try
          {

              DateTime bdateDateTime = Convert.ToDateTime(bdate);

              DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
              int Age = CurrentDate.Year - bdateDateTime.Year;// Convert.ToDateTime(dtbday.Text).Year;
              //this.txt_age.Text = Age.ToString();
              if (CurrentDate.Month < bdateDateTime.Month)
              {
                  Age--;
              }
              else if ((CurrentDate.Month == bdateDateTime.Month) && (CurrentDate.Day < bdateDateTime.Day))
              {

                  Age--;
              }
              return Age.ToString();


          }
          catch (Exception)
          {

              return "";
          }

        



      }
    }
}
