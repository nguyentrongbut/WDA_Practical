using HR.Application.DTOs;
using HR.Application.Interfaces;
using HR.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HR.Manage.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IDepartmentRepository _departmentRepo;

        public EmployeeController(
            IEmployeeRepository employeeRepo,
            IDepartmentRepository departmentRepo)
        {
            _employeeRepo = employeeRepo;
            _departmentRepo = departmentRepo;
        }

        // GET: Employee/Index
        public async Task<IActionResult> Index()
        {
            // Lấy danh sách nhân viên
            var employees = (await _employeeRepo.GetAllAsync()).ToList();

            // Lấy danh sách phòng ban để render dropdown
            var departments = await _departmentRepo.GetAllAsync();
            ViewBag.Departments = departments;

            return View(employees);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["ToastError"] = "Invalid input. Please check the form.";
                return RedirectToAction(nameof(Index));
            }

            var employee = new Employee
            {
                EmployeeName = dto.EmployeeName,
                EmployeeCode = dto.EmployeeCode,
                Rank = dto.Rank,
                DepartmentId = dto.DepartmentId
            };

            await _employeeRepo.AddAsync(employee);
            TempData["ToastSuccess"] = $"Created employee successfully!";
            return RedirectToAction(nameof(Index));
        }

        // POST: Employee/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeEditDto dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["ToastError"] = "Invalid input. Please check the form.";
                return RedirectToAction(nameof(Index));
            }

            var employee = await _employeeRepo.GetByIdAsync(dto.Id);
            if (employee == null)
            {
                TempData["ToastError"] = "Employee not found!";
                return RedirectToAction(nameof(Index));
            }

            employee.EmployeeName = dto.EmployeeName;
            employee.EmployeeCode = dto.EmployeeCode;
            employee.Rank = dto.Rank;
            employee.DepartmentId = dto.DepartmentId;

            await _employeeRepo.UpdateAsync(employee);
            TempData["ToastSuccess"] = $"Updated employee  successfully!";
            return RedirectToAction(nameof(Index));
        }

        // POST: Employee/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            var employee = await _employeeRepo.GetByIdAsync(Id);
            if (employee == null)
            {
                TempData["ToastError"] = "Employee not found!";
                return RedirectToAction(nameof(Index));
            }

            await _employeeRepo.DeleteAsync(Id);
            TempData["ToastSuccess"] = $"Deleted employee  successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}
