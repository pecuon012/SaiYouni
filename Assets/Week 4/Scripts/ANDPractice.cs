using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANDPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra tuổi, giấy phép, và kinh nghiệm
        BaiTap2(); // Kiểm tra điều kiện vào công viên giải trí
        BaiTap3(); // Điều kiện đạt học bổng
        BaiTap4(); // Kiểm tra đăng ký hợp lệ
        BaiTap5(); // Kiểm tra điều kiện thi lại
        BaiTap6(); // Xét tuyển nhân viên
        BaiTap7(); // Kiểm tra điều kiện mua hàng
        BaiTap8(); // Đủ điều kiện nhận phần thưởng
        BaiTap9(); // Kiểm tra điều kiện thăng chức
        BaiTap10(); // Điều kiện nhận vé miễn phí
    }

    // Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm
    void BaiTap1()
    {
        int tuoi = 20;
        bool coGiayPhepLaiXe = true;
        int namKinhNghiem = 2;

        if (tuoi > 18 && coGiayPhepLaiXe && namKinhNghiem > 1)
        {
            Debug.Log("Bạn đủ điều kiện lái xe.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện lái xe.");
        }
        // Nhập tuổi, giấy phép lái xe, và kinh nghiệm lái xe
        // Kiểm tra nếu người dùng trên 18 tuổi, có giấy phép lái xe, và có kinh nghiệm trên 1 năm
    }

    // Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí
    void BaiTap2()
    {
        bool coVe = true;
        bool daDangKyTruoc = true;
        bool coTienSuBenhTim = false;

        if (coVe && daDangKyTruoc && !coTienSuBenhTim)
        {
            Debug.Log("Bạn có thể vào công viên giải trí.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện vào công viên.");
        }
        // Nhập thông tin về vé, đã đăng ký trước, và tiền sử bệnh tim
        // Kiểm tra nếu người dùng có vé, đã đăng ký trước, và không có tiền sử bệnh tim
    }

    // Bài Tập 3: Điều Kiện Đạt Học Bổng
    void BaiTap3()
    {
        float diemTrungBinh = 9.2f;
        float diemHoatDongNgoaiKhoa = 8.5f;
        bool viPhamKyLuat = false;

        if (diemTrungBinh >= 9.0f && diemHoatDongNgoaiKhoa >= 8.0f && !viPhamKyLuat)
        {
            Debug.Log("Bạn đủ điều kiện nhận học bổng.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện nhận học bổng.");
        }
        // Nhập điểm trung bình, điểm hoạt động ngoại khóa, và kiểm tra kỷ luật
        // Kiểm tra nếu điểm trung bình >= 9.0, điểm ngoại khóa >= 8.0, và không vi phạm kỷ luật
    }

    // Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ
    void BaiTap4()
    {
        bool emailHopLe = true;
        bool daXacNhanQuaDienThoai = true;
        bool daThanhToanPhi = true;

        if (emailHopLe && daXacNhanQuaDienThoai && daThanhToanPhi)
        {
            Debug.Log("Đăng ký của bạn hợp lệ.");
        }
        else
        {
            Debug.Log("Đăng ký không hợp lệ.");
        }
        // Nhập thông tin email, xác nhận qua điện thoại, và phí tham gia
        // Kiểm tra nếu email hợp lệ, đã xác nhận qua điện thoại, và đã thanh toán phí tham gia
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại
    void BaiTap5()
    {
        float diemTongKet = 4.8f;
        int soMonTruot = 2;
        int diemChuyenCan = 80;

        if (diemTongKet < 5.0f && soMonTruot <= 2 && diemChuyenCan > 75)
        {
            Debug.Log("Bạn đủ điều kiện thi lại.");
        }
        else
        {
            Debug.Log("Bạn không đủ điều kiện thi lại.");
        }
        // Nhập điểm tổng kết, số môn thi trượt, và điểm chuyên cần
        // Kiểm tra nếu điểm tổng kết < 5.0, số môn trượt <= 2, và điểm chuyên cần > 75%
    }

    // Bài Tập 6: Xét Tuyển Nhân Viên
    void BaiTap6()
    {
        bool totNghiepDaiHoc = true;
        int namKinhNghiem = 3;
        bool quaBaiKiemTra = true;

        if (totNghiepDaiHoc && namKinhNghiem >= 2 && quaBaiKiemTra)
        {
            Debug.Log("Ứng viên đủ điều kiện tuyển dụng.");
        }
        else
        {
            Debug.Log("Ứng viên chưa đủ điều kiện.");
        }
        // Nhập thông tin về bằng đại học, kinh nghiệm và bài kiểm tra năng lực
        // Kiểm tra nếu ứng viên đã tốt nghiệp đại học, có ít nhất 2 năm kinh nghiệm, và vượt qua bài kiểm tra năng lực
    }

    // Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap7()
    {
        int soTienHienCo = 500;
        int giaSanPham = 400;
        bool hangTrongKho = true;
        bool duDieuKienKhuyenMai = true;

        if (soTienHienCo >= giaSanPham && hangTrongKho && duDieuKienKhuyenMai)
        {
            Debug.Log("Bạn có thể mua hàng.");
        }
        else
        {
            Debug.Log("Bạn không thể mua hàng.");
        }
        // Nhập số tiền hiện có, kiểm tra hàng trong kho và chương trình khuyến mãi
        // Kiểm tra nếu người dùng có đủ tiền, có hàng trong kho, và đủ điều kiện tham gia khuyến mãi
    }

    // Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng
    void BaiTap8()
    {
        int soNhiemVuHoanThanh = 12;
        float diemNhiemVu = 8.2f;
        bool daDangNhap7NgayQua = true;

        if (soNhiemVuHoanThanh >= 10 && diemNhiemVu >= 8.0f && daDangNhap7NgayQua)
        {
            Debug.Log("Bạn đủ điều kiện nhận phần thưởng.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện nhận thưởng.");
        }
        // Nhập thông tin về nhiệm vụ hoàn thành, điểm trung bình nhiệm vụ, và đăng nhập hệ thống
        // Kiểm tra nếu đã hoàn thành ít nhất 10 nhiệm vụ, điểm nhiệm vụ >= 8, và đăng nhập vào hệ thống trong 7 ngày qua
    }

    // Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap9()
    {
        int namLamViec = 6;
        bool datChiTieu = true;
        bool viPhamKyLuat = false;

        if (namLamViec > 5 && datChiTieu && !viPhamKyLuat)
        {
            Debug.Log("Bạn đủ điều kiện thăng chức.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện thăng chức.");
        }
        // Nhập số năm làm việc, chỉ tiêu công việc và vi phạm kỷ luật
        // Kiểm tra nếu đã làm việc trên 5 năm, đạt chỉ tiêu công việc và không vi phạm kỷ luật
    }

    // Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí
    void BaiTap10()
    {
        int tuoi = 65;
        bool laThanhVienVIP = true;
        int soLanMuaVe = 3;

        if (tuoi > 60 && laThanhVienVIP && soLanMuaVe >= 3)
        {
            Debug.Log("Bạn đủ điều kiện nhận vé miễn phí.");
        }
        else
        {
            Debug.Log("Bạn chưa đủ điều kiện nhận vé miễn phí.");
        }
        // Nhập tuổi, trạng thái thành viên VIP, và số lần mua vé trong năm
        // Kiểm tra nếu người dùng trên 60 tuổi, là thành viên VIP, và đã mua vé ít nhất 3 lần trong năm
    }
}
