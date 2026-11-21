using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeSuKienWeb.Data;
using VeSuKienWeb.Models;

namespace VeSuKienWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminChuDeController : Controller
    {
        private readonly NguCanhSuKien _db;

        public AdminChuDeController(NguCanhSuKien db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var danhSach = await _db.ChuDeSuKien
                .AsNoTracking()
                .OrderByDescending(x => x.TrangThai)
                .ThenBy(x => x.TenChuDe)
                .ToListAsync();

            return View("~/Views/Admin/QuanLyChuDe.cshtml", danhSach);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Them(
            string tenChuDe,
            string? moTa)
        {
            tenChuDe = (tenChuDe ?? "").Trim();
            moTa = moTa?.Trim();

            if (string.IsNullOrWhiteSpace(tenChuDe))
            {
                TempData["Loi"] = "Vui lòng nhập tên chủ đề.";
                return RedirectToAction(nameof(Index));
            }

            if (tenChuDe.Length > 100)
            {
                TempData["Loi"] = "Tên chủ đề không được quá 100 ký tự.";
                return RedirectToAction(nameof(Index));
            }

            if (moTa?.Length > 500)
            {
                TempData["Loi"] = "Mô tả không được quá 500 ký tự.";
                return RedirectToAction(nameof(Index));
            }

            bool daTonTai = await _db.ChuDeSuKien
                .AnyAsync(x => x.TenChuDe == tenChuDe);

            if (daTonTai)
            {
                TempData["Loi"] = "Tên chủ đề này đã tồn tại.";
                return RedirectToAction(nameof(Index));
            }

            var chuDe = new ChuDeSuKien
            {
                TenChuDe = tenChuDe,
                MoTa = moTa,
                TrangThai = true
            };

            _db.ChuDeSuKien.Add(chuDe);

            try
            {
                await _db.SaveChangesAsync();
                TempData["ThanhCong"] = "Thêm chủ đề thành công.";
            }
            catch (DbUpdateException)
            {
                TempData["Loi"] =
                    "Không thể thêm chủ đề. Vui lòng kiểm tra lại tên chủ đề.";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Sua(
            int chuDeId,
            string tenChuDe,
            string? moTa)
        {
            var chuDe = await _db.ChuDeSuKien
                .FirstOrDefaultAsync(x => x.ChuDeId == chuDeId);

            if (chuDe == null)
            {
                TempData["Loi"] = "Không tìm thấy chủ đề.";
                return RedirectToAction(nameof(Index));
            }

            tenChuDe = (tenChuDe ?? "").Trim();
            moTa = moTa?.Trim();

            if (string.IsNullOrWhiteSpace(tenChuDe))
            {
                TempData["Loi"] = "Tên chủ đề không được để trống.";
                return RedirectToAction(nameof(Index));
            }

            if (tenChuDe.Length > 100 || moTa?.Length > 500)
            {
                TempData["Loi"] = "Tên chủ đề hoặc mô tả vượt quá độ dài cho phép.";
                return RedirectToAction(nameof(Index));
            }

            bool trungTen = await _db.ChuDeSuKien
                .AnyAsync(x =>
                    x.ChuDeId != chuDeId &&
                    x.TenChuDe == tenChuDe);

            if (trungTen)
            {
                TempData["Loi"] = "Tên chủ đề này đã tồn tại.";
                return RedirectToAction(nameof(Index));
            }

            chuDe.TenChuDe = tenChuDe;
            chuDe.MoTa = moTa;

            try
            {
                await _db.SaveChangesAsync();
                TempData["ThanhCong"] = "Cập nhật chủ đề thành công.";
            }
            catch (DbUpdateException)
            {
                TempData["Loi"] =
                    "Không thể cập nhật chủ đề. Vui lòng thử lại.";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DoiTrangThai(int chuDeId)
        {
            var chuDe = await _db.ChuDeSuKien
                .FirstOrDefaultAsync(x => x.ChuDeId == chuDeId);

            if (chuDe == null)
            {
                TempData["Loi"] = "Không tìm thấy chủ đề.";
                return RedirectToAction(nameof(Index));
            }

            chuDe.TrangThai = !chuDe.TrangThai;

            await _db.SaveChangesAsync();

            TempData["ThanhCong"] = chuDe.TrangThai
                ? "Đã bật chủ đề."
                : "Đã tắt chủ đề. Dữ liệu cũ vẫn được giữ nguyên.";

            return RedirectToAction(nameof(Index));
        }
    }
}
