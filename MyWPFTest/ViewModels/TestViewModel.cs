using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.EntityFrameworkCore;
using MyWPFTest.DBContext;
using MyWPFTest.Models;
using MyWPFTest.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyWPFTest.ViewModels
{
    public partial class TestViewModel 
    {
        private ObservableCollection<Employee> employeeOb;
        public IEnumerable<Employee> EmployeeOb => employeeOb;
        
        public TestViewModel()
        {
            employeeOb = new ObservableCollection<Employee>();
        }

        [RelayCommand]
        private async Task Test()
        {
            QuanannhatContext db = Singleton.GetInstance().db;
            employeeOb.Clear();
            foreach(Employee employee in db.Employees.Include(e => e.Information).ToList())
            {
                employeeOb.Add(employee);
            }
        }
    }
}
