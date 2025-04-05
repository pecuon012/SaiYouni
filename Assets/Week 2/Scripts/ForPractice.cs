using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
public class ForPractice : MonoBehaviour
{
    [SerializeField] public int n_fibonacci; // [SerializeField] Cho phép chỉnh sửa trong Inspector nhưng vẫn là private
    [SerializeField] public int sogiaithua;//13
    [SerializeField] public int socanin;//bt14
    [SerializeField] public int giatribbatky; //bt16
    [SerializeField] public int sobatky; //bt17




    //private void Reset()
    //{
    //    baitap13();
    //}
    // Start is called before the first frame update
    void Start()
    {
        //baitap1();
        //baitap2();
        //baitap3();
        //baitap4();
        //baitap5();
        //baitap6();
        //baitap7();
        //baitap8();
        //baitap9();
        //baitap10();
        //baitap11();
        //baitap12();
        //baitap13();
        //baitap14();
        //baitap15();
        //baitap16();
        //baitap17();
        //baitap18();
        //baitap19();
        baitap20();
    }
    void baitap1()//Viết một chương trình sử dụng vòng lặp For để in các số từ 1 đến 100.
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }
    void baitap2()//Viết một chương trình sử dụng vòng lặp For để tính tổng các số từ 1 đến 50.
    {
        int tong = 0;
        for (int i = 1; i <= 50; i++)
        {
            tong += i;
        }
        Debug.Log("tong 1 den 50 la: " + tong);
    }
    void baitap3() //Viết một chương trình sử dụng vòng lặp For để in tất cả các số chẵn từ 1 đến 100.
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    void baitap4()//Viết một chương trình sử dụng vòng lặp For để tính tích của các số từ 1 đến 10.
    {
        int mutiplte = 1;
        for (int i = 1; i <= 10; i++)
        {

            mutiplte *= i;

        }
        Debug.Log(mutiplte);
    }
    void baitap5()//Viết một chương trình sử dụng vòng lặp For để tìm số lớn nhất trong một mảng số nguyên
    {
        short[] mang_songuyen = { 0, 5, 8, 9, -7, 88, 1, 10, 2 }; // 9 pt
        short max_value = mang_songuyen[0]; //gắn giá trị đầu tiên cho mảng
        for (int i = 1; i < mang_songuyen.Length; i++) // i = 1 để bắt đầu so sánh mảng [0] với [1]
        {
            if (mang_songuyen[i] > max_value)
            {
                max_value = mang_songuyen[i];
            }
        }
        Debug.Log("Số lớn nhất là: " + max_value);
    }
    void baitap6()//Tính Tổng Các Số Lẻ Từ 1 Đến 100
    {
        int total = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                total += i;
            }
        }
        Debug.Log("Tổng Các Số Lẻ Từ 1 Đến 100: " + total);
    }
    void baitap7()//Đảo Ngược Chuỗi
    {
        string[] name_user = { "Nguyen", "Van", "Tan" };
        int dodaichuoi = name_user.Length; // độ dài đi từ 1 2 3 
        for (int i = dodaichuoi - 1; i >= 0; i--) // mảng thì đi từ 0 nên trừ 1 mới hiểu 0 1 2 
        {
            Debug.Log(name_user[i]);
        }
        Debug.Log(name_user.Length);
    }
    void baitap8()// In Ra Bảng Cửu Chương Viết một chương trình sử dụng vòng lặp For để in ra bảng cửu chương của một số bất kỳ(từ 1 đến 10).
    {
        int bangcuuchuong = 0;// Em sẽ in bảng cửu chương 5
        for (int i = 1; i <= 10; i++)
        {
            bangcuuchuong = 5 * i;
            Debug.Log(bangcuuchuong);
        }
    }
    void baitap9()// Đếm Các Số Nguyên Dương Trong Mảng
    {
        int sodem = 0;
        int[] mangsonguyen = { -2, 5, -6, 9, 7, 4, 0, 6 }; /// 8 phan tu
        for (int i = 0; i < mangsonguyen.Length; i++)
        {
            if (mangsonguyen[i] >= 0) sodem++;
        }
        Debug.Log("mảng có " + sodem + " số nguyên dương" + mangsonguyen.Length);

    }
    void baitap10()// In Tam Giác Số Viết một chương trình sử dụng vòng lặp For để in ra một tam giác số như sau: 1 12 123 1234 12345
    {
        int n = 5;
        // Vòng lặp duyệt qua từng dòng
        for (int i = 1; i <= n; i++)
        {
            // Vòng lặp để in các số từ 1 đến i
            string line = "";
            for (int j = 1; j <= i; j++)
            {
                line += j.ToString(); // Tạo chuỗi số noted nghĩa là chuyển số thành string xong chuyển số ( string ) vào chuỗi line và in ra line 
            }
            // In chuỗi lên console
            Debug.Log(line);
        }
    }
    void baitap11()//Tìm Phần Tử Nhỏ Nhất Trong Mảng
    {
        int[] mang_songuyen = { -2, 5, -6, -9, 7, 4, };
        int min_value = 0;
        for (int i = 0; i < mang_songuyen.Length; i++)
        {
            if (min_value > mang_songuyen[i]) min_value = mang_songuyen[i];
        }
        Debug.Log("so nho nhat trong mảng là: " + min_value);
    }
    void baitap12()//Fibonacci 
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i <= n_fibonacci; i++)
        {
            Debug.Log(a);
            int then = a + b;
            a = b;
            b = then;

        }
    }
    void baitap13()//Viết chương trình tính giai thừa của số n 
    {
        int total = 1;/// giai thừa từ 1
        for (int i = 1; i <= sogiaithua; i++)
        {
            total *= i;
        }
        Debug.Log(total);
    }
    void baitap14()//In Ra Các Số Nguyên Từ n Đến 1 Viết một chương trình sử dụng vòng lặp For để in ra các số nguyên từ n đến 1, với n là số nhập từ người dùng.
    {
        for (int i = socanin; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }
    void baitap15()//Viết một chương trình sử dụng vòng lặp For để tính tổng các phần tử trong một mảng số nguyên.
    {
        int total = 0;
        int[] mang = { -9, -8, 6, 5, 4, };
        for (int i = 0; i < mang.Length; i++)
        {
            total += mang[i];
        }
        Debug.Log(total);
    }
    void baitap16()//Kiểm Tra Số Nguyên Tố Viết một chương trình sử dụng vòng lặp For để kiểm tra xem một số nguyên có phải là số nguyên tố hay không.
    {
        bool kiemtra(int giatribbatky)
        {
            if (giatribbatky < 2) return false;

            for (int i = 2; i <= Mathf.Sqrt(giatribbatky); i++)
            {
                if (giatribbatky % i == 0)
                    return false;
            }
            return true;
        }
        if (kiemtra(giatribbatky) == true) Debug.Log("yes");
        if (kiemtra(giatribbatky) == false) Debug.Log("no");
    }
    void baitap17()// Viết một chương trình sử dụng vòng lặp For để in ra các số từ 1 đến 100 chia hết cho 3.
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
    void baitap18()//Tìm Tổng Các Số Chẵn Trong Mảng Viết một chương trình sử dụng vòng lặp For để tính tổng các phần tử chẵn trong một mảng số nguyên.
    {
        int[] mangsonguyen = { -6, -5, -4, 10, 20, -20, 2 }; // => = 2
        int total = 0;
        for (int i = 0; i < mangsonguyen.Length; i++)
        {
            if (mangsonguyen[i] % 2 == 0)
            {
                total += mangsonguyen[i];
            }
        }
        Debug.Log(total);
    }
    void baitap19()//Viết một chương trình sử dụng vòng lặp For để tính trung bình cộng của các phần tử trong một mảng số nguyên.
    {
        int[] mangsonguyen = { -6, -5, -4, 10, 20, -20, 2 };
        float total = 0;
        float total_avg; // can so thuc
        for (int i = 0; i < mangsonguyen.Length; i++)
        {
            total += mangsonguyen[i];
        }
        total_avg = total / mangsonguyen.Length;
        Debug.Log(total_avg);
    }
    void baitap20()
    {
        string chuoi = "NGuyen Van Tan "; //4
        int demKyTuHoa = 0;

        for (int i = 0; i < chuoi.Length; i++)
        {
            if (char.IsUpper(chuoi[i])) // check ky tu chuoi 
            {
                demKyTuHoa++;
            }
        }
                Debug.Log("Số ký tự hoa trong chuỗi là: " + demKyTuHoa);
    }
}





