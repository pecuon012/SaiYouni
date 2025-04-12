using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    [SerializeField] public int n; //bt1
    [SerializeField] public float dtb; //bt3
    [SerializeField] public float a, b, c; //bt4
    [SerializeField] public short tuoi; //bt4
    [SerializeField] public int thoigianlamviec; //bt4
    [SerializeField] public string Cothethanhvienkhong; //bt4
    [SerializeField] public float soKWdien;
    [SerializeField] public string Rate;
    [SerializeField] public int Exp;
    public int soLuongHienTai = 80;
    public bool daHoanThanhKhoaCoBan = true;
    public float diemTongKet = 8.2f;
    public bool coThuGioiThieu = true;

    // Biến mô phỏng kho còn chỗ trống hay không
    public bool khoConCho = true;

    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        //BaiTap1();
        //BaiTap2();
        //BaiTap5();
        //BaiTap6();
        //BaiTap7();
        //BaiTap8();
        //BaiTap9();
        //BaiTap10();
        //BaiTap11();
        //bt12();
        //BaiTap13();
        //BaiTap14();
        //BaiTap15();
        //BaiTap16();
        //BaiTap17();
        //BaiTap18();
        //BaiTap19();
        BaiTap20();
    }


    void BaiTap1() //Kiểm Tra Số Dương, Âm Hoặc Bằng 0 Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím là số dương, âm, hay bằng 0.
    {
        if (n == 0) Debug.Log(n + " la so 0");
        if (n >= 1) Debug.Log(n + " la so duong");
        else Debug.Log("la so am");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        if (n % 2 == 0) Debug.Log(n + "la so chan");
        else Debug.Log(n + "la so le");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        if (dtb >= 5) Debug.Log("PASS");
        else Debug.Log("PASS AWAY");
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        float max = 0;
        if (a > b) Debug.Log(" So lon nhat la " + a);
        if (b > a) Debug.Log(" So lon nhat la " + b);
        else Debug.Log(" a = b ");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        int sanpham1 = 530;
        if (n >= sanpham1)
        {
            Debug.Log(" Bạn đủ điều kiện mua hàng");
        }
        else Debug.Log(" Bạn  không đủ điều kiện mua hàng");
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        int n = 0;
        if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
        {
            Debug.Log(n + " là năm nhuận.");
        }
        else
        {
            Debug.Log(n + " không phải là năm nhuận.");
        }
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        if (tuoi >= 18) Debug.Log(" giá vé là 100k");
        else Debug.Log(" giá vé là 50k");
        // Nhập tuổi của người mua vé từ bàn phím
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        if (dtb >= 9) Debug.Log("đạt danh hiệu xuất sắc");
        else Debug.Log("Nice Try");
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        float max = 0;
        if (a >= b && a >= n) max = a;
        if (b >= a && b >= n) max = b;
        else max = n;
        Debug.Log("so lon nhat la so " + max);
        // Nhập ba số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong ba số đó
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        int luongcodinh = 600;
        int luongtheogio = 20;
        int thoigianbonus = 0;
        int luongbonus = 0;
        int total;
        if (thoigianlamviec > 40)
        {
            thoigianbonus = thoigianlamviec - 40;
            luongbonus = luongtheogio * thoigianbonus;
            total = luongbonus + luongcodinh;
            Debug.Log(" thoi gian ban da lam " + thoigianlamviec + "luong thuong them  se la " + luongbonus + " tong cong ban nhan" + total);
        }
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        int tuoi_a = 15;
        string check = "yes";
        if (tuoi_a > 18 && Cothethanhvienkhong == check)
        {
            Debug.Log("Ban duoc phep vao cau lac bo");
        }
        else
        {
            Debug.Log("Ban khong duoc phep vao cau lac bo.");
        }
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void bt12()
    {
        if (dtb >= 9.0) Debug.Log("hoc sinh xuat xac");
        else if (dtb >= 8.0) Debug.Log("hoc sinh gioi");
        else if (dtb >= 7.0) Debug.Log("hoc sinh kha");
        else if (dtb >= 5.0) Debug.Log("hoc sinh trung binh");
        else Debug.Log("hoc sinh yeu");

        // Nhập điểm trung bình của học sinh từ bàn phím
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        float total = 0;
        if (soKWdien <= 100)
        {
            total = soKWdien * 1.500f;
        }
        else total = (100 * 1.500f) + (soKWdien - 100) * 2000;
        // Nhập số điện tiêu thụ từ bàn phím
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        string good = "good ";
        if (Exp >= 5 && Rate == good) Debug.Log("du dieu kien thang chuc");
        else Debug.Log(" khong du dieu kien thang chuc");

        // Nhập số năm làm việc và đánh giá công việc
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        if (n >= 500000) Debug.Log("freeship");
        else Debug.Log(" k freeship");
        // Nhập giá trị đơn hàng từ bàn phím
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        double s = 20000000;
        double total = 0;
        if (s <= 10000000) total = s * 0.05;
        if (s > 10000000 && s < 20000000) total = s * 0.1;
        else total = s * 0.2;
        Debug.Log(total);

        // Nhập thu nhập từ bàn phím
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        float avg = 0;
        avg = (a * b * c) / 3;
        if (avg >= 5.0) Debug.Log("passed");
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()

    {
        if (soLuongHienTai < 100 && khoConCho)
        {
            Debug.Log("✅ Có thể nhập thêm hàng.");
        }
        else
        {
            Debug.Log("❌ Không thể nhập thêm hàng.");
        }

        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        if (n == 10) Debug.Log("la so 10");
        if (n > 10) Debug.Log("la so ban nhap lon hon 10");
        else Debug.Log("be hon 10");
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        if (daHoanThanhKhoaCoBan && diemTongKet >= 7.0f && coThuGioiThieu)
        {
            Debug.Log("✅ Học sinh đủ điều kiện đăng ký khóa học nâng cao.");
        }
        else
        {
            Debug.Log("❌ Học sinh KHÔNG đủ điều kiện đăng ký khóa học nâng cao.");
        }
    }// Nhập điểm tổng kết và các điều kiện khác từ bàn phím
     // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
}

