using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class job
    {
        dbEW accessDB = new dbEW();
        DataTable dt = new DataTable();

        public int JobID
        {
            get
            {
                return JobID;
            }
            set
            {
                JobID = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return CustomerID;
            }
            set
            {
                CustomerID = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return EmployeeID;
            }
            set
            {
                EmployeeID = value;
            }
        }

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }

        public String DateLogged
        {
            get
            {
                return DateLogged;
            }
            set
            {
                DateLogged = value;
            }
        }

        public string DateStarted
        {
            get
            {
                return DateStarted;
            }
            set
            {
                DateStarted = value;
            }
        }

        public string EstimatedCompletionDate
        {
            get
            {
                return EstimatedCompletionDate;
            }
            set
            {
                EstimatedCompletionDate = value;
            }
        }

        public string DateCompleted
        {
            get
            {
                return DateCompleted;
            }
            set
            {
                DateCompleted = value;
            }
        }

        public int JobOpenClose
        {
            get
            {
                return JobOpenClose;
            }
            set
            {
                JobOpenClose = value;
            }
        }

        public void insertJob(job currentJob)
    {
        string query = "INSERT INTO jobs(customer_id, employee_id, description, date_logged, date_started, estimated_completion, date_completed, job_open_close) VALUES (" + currentJob.CustomerID + ", " + currentJob.EmployeeID + ", '" + currentJob.Description + "', " + currentJob.DateLogged + ", " + currentJob.DateStarted + ", " + currentJob.EstimatedCompletionDate + ", " + currentJob.DateCompleted + ", '" + currentJob.JobOpenClose + "')";
    }

        public DataTable getOpenJobs()
        {
            string query = "select * FROM jobs WHERE job_open_close = 1";
            dt = accessDB.grabAll(query);
            return dt;

        }

        public DataTable getCompletedJobs()
        {
            string query = "select * FROM jobs WHERE job_open_close = 2";
            dt = accessDB.grabAll(query);
            return dt;

        }



    }

}