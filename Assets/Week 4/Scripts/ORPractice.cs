using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        //BaiTap1(); // Kiểm tra vé vào cửa
        //BaiTap2(); // Điều kiện trúng thưởng
        //BaiTap3(); // Kiểm tra điều kiện vay tiền
        //BaiTap4(); // Điều kiện nhận học bổng
        //BaiTap5(); // Kiểm tra đăng ký sự kiện
        //BaiTap6(); // Điều kiện lái xe
        //BaiTap7(); // Kiểm tra quyền truy cập tài liệu
        //BaiTap8(); // Kiểm tra điều kiện tham gia khóa học
        //BaiTap9(); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1()
    {
        bool coVeHopLe = true;
        bool laThanhVienVIP = false;
        bool duocMoi = false;

        if (coVeHopLe || laThanhVienVIP || duocMoi)
        {
            Debug.Log("Bạn có thể vào sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không được phép vào sự kiện.");
        }
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2()
    {
        bool trungGiaiNhat = false;
        bool trungGiaiNhi = true;
        bool trungGiaiBa = false;

        if (trungGiaiNhat || trungGiaiNhi || trungGiaiBa)
        {
            Debug.Log("Chúc mừng! Bạn đã trúng thưởng.");
        }
        else
        {
            Debug.Log("Rất tiếc, bạn không trúng thưởng.");
        }
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3()
    {
        bool thuNhapOnDinh = false;
        bool coTaiSanTheChap = true;
        bool coNguoiBaoLanh = false;

        if (thuNhapOnDinh || coTaiSanTheChap || coNguoiBaoLanh)
        {
            Debug.Log("Bạn đủ điều kiện vay tiền.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện vay tiền.");
        }
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4()
    {
        bool thanhTichXuatSac = false;
        bool hoatDongNgoaiKhoaTot = true;
        bool giaDinhKhoKhan = false;

        if (thanhTichXuatSac || hoatDongNgoaiKhoaTot || giaDinhKhoKhan)
        {
            Debug.Log("Bạn đủ điều kiện nhận học bổng.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện nhận học bổng.");
        }
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5()
    {
        bool emailHopLe = true;
        bool soDienThoaiXacThuc = false;
        bool daDangKyQuaWeb = false;

        if (emailHopLe || soDienThoaiXacThuc || daDangKyQuaWeb)
        {
            Debug.Log("Bạn có thể đăng ký sự kiện.");
        }
        else
        {
            Debug.Log("Bạn không thể đăng ký sự kiện.");
        }
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6()
    {
        bool coBangLai = true;
        bool xeDangKyHopLe = false;
        bool coBaoHiemXe = false;

        if (coBangLai || xeDangKyHopLe || coBaoHiemXe)
        {
            Debug.Log("Bạn có thể lái xe.");
        }
        else
        {
            Debug.Log("Bạn không được phép lái xe.");
        }
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7()
    {
        bool laQuanTriVien = false;
        bool duocCapQuyen = true;
        bool coMaXacThuc = false;

        if (laQuanTriVien || duocCapQuyen || coMaXacThuc)
        {
            Debug.Log("Bạn có quyền truy cập tài liệu.");
        }
        else
        {
            Debug.Log("Bạn không có quyền truy cập tài liệu.");
        }
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8()
    {
        bool coThuGioiThieu = true;
        bool daHoanThanhKiemTra = false;
        bool coKinhNghiemLienQuan = false;

        if (coThuGioiThieu || daHoanThanhKiemTra || coKinhNghiemLienQuan)
        {
            Debug.Log("Bạn có thể tham gia khóa học.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện tham gia khóa học.");
        }
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9()
    {
        bool coMaKhuyenMai = false;
        bool laThanhVienVIP = true;
        bool trongThoiGianMienPhi = false;

        if (coMaKhuyenMai || laThanhVienVIP || trongThoiGianMienPhi)
        {
            Debug.Log("Bạn có thể tải ứng dụng miễn phí.");
        }
        else
        {
            Debug.Log("Bạn không thể tải ứng dụng miễn phí.");
        }
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10()
    {
        bool chiTieuDatYeuCau = true;
        bool laKhachHangThanThiet = false;
        bool coChuongTrinhKhuyenMai = false;

        if (chiTieuDatYeuCau || laKhachHangThanThiet || coChuongTrinhKhuyenMai)
        {
            Debug.Log("Bạn có thể sử dụng dịch vụ đặc biệt.");
        }
        else
        {
            Debug.Log("Bạn không thể sử dụng dịch vụ đặc biệt.");
        }
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
    }
}
