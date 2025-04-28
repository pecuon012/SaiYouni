using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RecursionPractice : MonoBehaviour
{
    [SerializeField] public long n = 0;
    [SerializeField] public long a = 0;
    [SerializeField] public long b = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        //BaiTap1(); // Tính giai thừa của một số
        //BaiTap2(); // Tính tổng các số từ 1 đến n
        BaiTap3();
        //BaiTap4(); // Đếm ngược từ n về 1
        BaiTap5(); // Tìm UCLN của hai số
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    void BaiTap1()
    {
        int n = 5; // có thể thay đổi giá trị này để thử nghiệm
        if (n < 0)
        {
            Debug.Log("Không thể tính giai thừa cho số âm.");
        }
        else
        {
            long ketQua = GiaiThua(n);
            Debug.Log(n + "! = " + ketQua);
        }
    }

    long GiaiThua(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * GiaiThua(n - 1); // hàm gọi lại đệ quy 
    }

    // Nhập số nguyên dương n từ bàn phím
    // Viết hàm đệ quy để tính giai thừa của n


    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    void BaiTap2()
    {

        tong(n);
        long tong(long n)
        {
            if (n == 1) return 1;
            return n + tong(n - 1);
        }
    }
    // Nhập số nguyên dương n từ bàn phím
    // Viết hàm đệ quy để tính tổng các số từ 1 đến n


    // Bài Tập 3: Chuỗi Fibonacci
    void BaiTap3()
    {
        //Debug.Log("Fibonacci(" + n + ") = " + fiboanci(n));
        //long fiboanci(long n)
        //{
        //    if (n == 0) return 0;
        //    if (n == 1) return 1;
        //    return fiboanci(n - 1) + fiboanci(n - 2);
        //}
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        if (n < 0)
        {
            Debug.Log("Vui lòng nhập số nguyên không âm.");
        }
        else
        {
            long ketQua = Fibonacci(n);
            Debug.Log("Fibonacci thứ " + n + " là: " + ketQua);
        }

        int Fibonacci(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4()
    {
        demnguoc(n);
        long demnguoc(long n)
        {
            Debug.Log(n);
            if (n == 1) return 1; // kết thúc 
            return demnguoc(n - 1);
        }// gọi lại hàm
         //}
         //{
         //    if (n <= 0)
         //    {
         //        Debug.Log("Vui lòng nhập số nguyên dương lớn hơn 0.");
         //    }
         //    else
         //    {
         //        Debug.Log("Đếm ngược từ " + n + " về 1:");
         //        DemNguocTu(n);
         //    }
         //}

        //void DemNguocTu(long n)
        //{
        //    Debug.Log(n);
        //    if (n > 1)
        //    {
        //        DemNguocTu(n - 1);
        //    }
        //}
    }
    // Nhập số nguyên n từ bàn phím
    // Viết hàm đệ quy để đếm ngược từ n về 1


    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    void BaiTap5()
    {
        Debug.Log(ucln(a, b));
        long ucln(long a, long b)
        {
            if (b == 0) return a;
            return ucln(b, a % b);
        }

        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
    }
}


