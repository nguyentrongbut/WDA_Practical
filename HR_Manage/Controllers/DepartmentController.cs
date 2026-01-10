using HR.Application.DTOs;
using HR.Application.Interfaces;
using HR.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HR.Manage.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;

        public DepartmentController(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        // GET: List all departments
        public async Task<IActionResult> Index()
        {
            var departments = (await _departmentRepo.GetAllAsync()).ToList();
            return View(departments);
        }

        // POST: Create department
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentCreateDto dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["ToastError"] = "Invalid input. Please check the form.";
                return RedirectToAction(nameof(Index));
            }

            var department = new Department
            {
                DepartmentName = dto.DepartmentName,
                DepartmentCode = dto.DepartmentCode,
                Location = dto.Location,
                NumberOfPersonals = dto.NumberOfPersonals
            };

            await _departmentRepo.AddAsync(department);
            TempData["ToastSuccess"] = $"Created Department successfully!";
            return RedirectToAction(nameof(Index));
        }

        // POST: Edit department
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DepartmentEditDto dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["ToastError"] = "Invalid input. Please check the form.";
                return RedirectToAction(nameof(Index));
            }

            var existing = await _departmentRepo.GetByIdAsync(dto.Id);
            if (existing == null)
            {
                TempData["ToastError"] = "Department not found!";
                return RedirectToAction(nameof(Index));
            }

            existing.DepartmentName = dto.DepartmentName;
            existing.DepartmentCode = dto.DepartmentCode;
            existing.Location = dto.Location;
            existing.NumberOfPersonals = dto.NumberOfPersonals;

            await _departmentRepo.UpdateAsync(existing);
            TempData["ToastSuccess"] = $"Updated Department successfully!";
            return RedirectToAction(nameof(Index));
        }

        // POST: Delete department
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _departmentRepo.GetByIdAsync(id);
            if (department == null)
            {
                TempData["ToastError"] = "Department not found!";
                return RedirectToAction(nameof(Index));
            }

            await _departmentRepo.DeleteAsync(id);
            TempData["ToastSuccess"] = $"Deleted Department successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}
