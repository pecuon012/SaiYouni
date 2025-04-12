using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        int[] mang = { 1, 2, 3, 4, 5 };
        foreach (int so in mang)
        {
            Debug.Log("Phần tử: " + so);
        }

        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các phần tử trong mảng
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        int[] mang = { 1, 2, 3, 4, 5 };
        int tong = 0;
        foreach (int so in mang)
        {
            tong += so;
        }
        Debug.Log("Tổng: " + tong);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        int[] mang = { 3, 10, 5, 8 };
        int max = int.MinValue;
        foreach (int so in mang)
        {
            if (so > max) max = so;
        }
        Debug.Log("Lớn nhất: " + max);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        int[] mang = { 2, 5, 8, 9, 10 };
        int dem = 0;
        foreach (int so in mang)
        {
            if (so % 2 == 0) dem++;
        }
        Debug.Log("Số chẵn: " + dem);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        List<string> danhSach = new List<string> { "Apple", "Banana", "Cherry" };
        foreach (string ten in danhSach)
        {
            Debug.Log("Chuỗi: " + ten);
        }
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        List<string> danhSach = new List<string> { "Cat", "Elephant", "Tiger" };
        string daiNhat = "";
        foreach (string s in danhSach)
        {
            if (s.Length > daiNhat.Length) daiNhat = s;
        }
        Debug.Log("Chuỗi dài nhất: " + daiNhat);
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        int[] mang = { 1, 3, 5, 6, 8 };
        int tongLe = 0;
        foreach (int so in mang)
        {
            if (so % 2 != 0) tongLe += so;
        }
        Debug.Log("Tổng số lẻ: " + tongLe);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        int[] mang = { 2, 3, 4, 5, 6 };
        foreach (int so in mang)
        {
            if (so % 2 == 0)
                Debug.Log("Số chẵn: " + so);
        }
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        int[] mang = { 4, 7, 10 };
        int canTim = 7;
        bool tonTai = false;

        foreach (int so in mang)
        {
            if (so == canTim)
            {
                tonTai = true;
                break;
            }
        }

        Debug.Log(tonTai ? "Tồn tại!" : "Không tồn tại.");
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        int[] mang = { -3, 1, -1, 5 };
        int demAm = 0;
        foreach (int so in mang)
        {
            if (so < 0) demAm++;
        }
        Debug.Log("Số âm: " + demAm);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        int[] mang = { 5, 11, 20, 3 };
        foreach (int so in mang)
        {
            if (so > 10)
                Debug.Log("Số > 10: " + so);
        }
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        List<string> ds = new List<string> { "Cat", "Elephant", "Go" };
        string nganNhat = ds[0];

        foreach (string s in ds)
        {
            if (s.Length < nganNhat.Length) nganNhat = s;
        }

        Debug.Log("Chuỗi ngắn nhất: " + nganNhat);
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        int[] mang = { 1, 2, 3 };
        foreach (int so in mang)
        {
            Debug.Log("Nhân đôi: " + (so * 2));
        }
        // Tạo một mảng số nguyên
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        int[] mang = { 10, 20, 5, 30 };
        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int so in mang)
        {
            if (so > max)
            {
                secondMax = max;
                max = so;
            }
            else if (so > secondMax && so != max)
            {
                secondMax = so;
            }
        }

        Debug.Log("Số lớn thứ hai: " + secondMax);
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        List<string> ds = new List<string> { "Apple", "Banana", "Avocado" };
        foreach (string s in ds)
        {
            if (s.StartsWith("A"))
                Debug.Log("Chuỗi bắt đầu bằng A: " + s);
        }
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        List<string> ds = new List<string> { "Hi", "Hello", "Welcome" };
        bool tonTai = false;
        foreach (string s in ds)
        {
            if (s == "Hello")
            {
                tonTai = true;
                break;
            }
        }
        Debug.Log(tonTai ? "Có Hello" : "Không có Hello");
        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        int[] mang = { -1, 3, -5, 0 };
        foreach (int so in mang)
        {
            if (so < 0)
                Debug.Log("Số âm: " + so);
        }
        // Tạo một mảng số nguyên
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        int[] mang = { 2, 4, 2, 3, 2 };
        int canDem = 2;
        int dem = 0;

        foreach (int so in mang)
        {
            if (so == canDem) dem++;
        }

        Debug.Log("Số lần xuất hiện của " + canDem + ": " + dem);
        // Tạo một mảng số nguyên và một phần tử cụ thể
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        int[] mang = { 5, 15, 8, 20 };
        List<int> danhSachMoi = new List<int>();

        foreach (int so in mang)
        {
            if (so > 10) danhSachMoi.Add(so);
        }

        foreach (int so in danhSachMoi)
        {
            Debug.Log("Phần tử > 10: " + so);
        }
        // Tạo một mảng số nguyên
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        List<string> ds = new List<string> { "Apple", "Orange", "Kiwi", "Mango" };
        foreach (string s in ds)
        {
            if (s.Length > 5)
                Debug.Log("Chuỗi dài > 5: " + s);
        }

        // Tạo một danh sách các chuỗi
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
    }

}
