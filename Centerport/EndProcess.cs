﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MedicalManagementSoftware
{
  public   class EndProcess
    {
      public static void EndProcessQueryManagerr()
      {
          Process[] workers = Process.GetProcessesByName("Medical Management Software");
          foreach (Process worker in workers)
          {
              worker.Kill();
              worker.WaitForExit();
              worker.Dispose();
          }
      }

    }
}
