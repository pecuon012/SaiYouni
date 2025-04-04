# Agenda Phát Triển Game Week 1

## 1. Tìm Giá Trị Lớn Nhất Mà Int, Float và Double Trong Unity C# Có Thể Lưu Trữ
int[] scores: Khai báo một mảng (array) kiểu int, tên là scores.

new int[10]: Cấp phát bộ nhớ cho mảng gồm 10 phần tử, mỗi phần tử có kiểu int và mặc định là 0.

Ví dụ truy cập và gán giá trị:

scores[0] = 5;   // Gán giá trị 5 cho phần tử đầu tiên  
Debug.Log(scores[0]); // In ra 5  

## 2. Để Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng
Target -> Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng -> Game thủ thành chạy quảng cáo kiếm thu nhập đồng thời bỏ vào CV
https://docs.google.com/document/d/15iXhAkGQB1vpu_uzLzy0K21mcqSDC245h5H5GgsUeNo/edit?usp=sharing

## 3. Khai Báo Thêm 5 Methods Cho Class Enemy
=> Script

## 4. Khai Báo Thêm 5 Biến Cho Class Enemy
=> Script

## 5. Nhờ AI Giải Thích Câu Lệnh Này: `int[] scores = new int[10];`

## 6. Nhờ AI Giải Thích Về Rigidbody
Rigidbody trong Unity là một thành phần vật lý (Physics Component) giúp đối tượng trong game có thể:
✅ Chịu tác động của trọng lực (Gravity).
✅ Va chạm với các vật thể khác có Collider.
✅ Có thể di chuyển và xoay dựa trên lực tác động (AddForce).

## 7. Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
Trong C#, để lấy phần dư khi chia một số cho số khác, dùng toán tử %.

🔹 Ví dụ:

int soA = 10;
int soB = 3;
int soDu = soA % soB; // 10 % 3 = 1
Debug.Log(soDu); // Kết quả: 1
✅ Ứng dụng thực tế: Kiểm tra số chẵn/lẻ:

if (soA % 2 == 0) Debug.Log("Số chẵn");
else Debug.Log("Số lẻ");

## 8. Ngoài Các Kiểu Dữ Liệu Đã Giới Thiệu, Kể Tên 5 Kiểu Dữ Liệu Khác Của Unity C#
Ngoài int, float, bool, string, double, Unity có thêm:

1. Vector3: Đại diện cho một tọa độ 3D (x, y, z).
Vector3 viTri = new Vector3(1.0f, 2.0f, 3.0f);

2. Quaternion: Dùng để biểu diễn xoay (rotation).
Quaternion xoay = Quaternion.Euler(0, 90, 0);

3. Color: Đại diện cho màu sắc (RGBA).
Color mauDo = Color.red; // Màu đỏ

4. GameObject: Đại diện cho một đối tượng trong Unity.
GameObject player = GameObject.Find("Player");

5. Transform: Chứa thông tin vị trí, xoay, tỷ lệ của đối tượng.
Transform viTri = player.transform;

## 9. Ngoài Các Toán Tử Đã Giới Thiệu, Hãy Kể Tên 3 Toán Tử Khác

Ngoài +, -, *, /, %, có thêm:

1. Toán tử ?? (Null Coalescing Operator)

Dùng để gán giá trị mặc định nếu biến có giá trị null.

string name = null;
string defaultName = name ?? "Guest"; // Nếu name là null → "Guest"

2. Toán tử +=, -=, *=, /= (Toán tử gán kết hợp)

Rút gọn việc cập nhật giá trị biến.
int a = 5;
a += 3; // Tương đương a = a + 3;

3. Toán tử is (Kiểm tra kiểu dữ liệu)

Kiểm tra xem một biến có thuộc kiểu nào đó không.
object obj = "Hello";
if (obj is string) Debug.Log("obj là string");

