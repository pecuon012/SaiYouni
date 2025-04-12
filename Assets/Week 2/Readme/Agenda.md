# Agenda Phát Triển Game Week 2

## 1. Kể Tên 3 Hàm Màu Xanh (Blue) Mà Unity Sẽ Tự Động Gọi
1. Start()
Khi nào được gọi? Khi script được kích hoạt lần đầu, ngay trước frame đầu tiên.

Dùng làm gì? Khởi tạo giá trị, set up mọi thứ trước khi game loop bắt đầu.

Lưu ý: Không bị gọi nếu script bị disabled.

2. Update()
Khi nào được gọi? Mỗi frame trong suốt thời gian chạy game.

Dùng làm gì? Bắt input, update animation, logic game liên tục.

Lưu ý: Dùng nhiều thì... tiêu CPU đấy, tối ưu đi bro.

3. OnEnable()
Khi nào được gọi? Khi script được bật (enabled) hoặc đối tượng chứa nó được kích hoạt lại.

Dùng làm gì? Reset trạng thái, đăng ký event listener các kiểu.

Lưu ý: Cực kỳ useful khi xài pooling system.

Bonus thêm 1 phát: Awake() cũng là callback được Unity gọi tự động trước cả Start(), hay dùng để thiết lập Singleton hoặc load resource.

Tóm tắt quan trọng!
***************
Awake() → Khởi động cực sớm.

OnEnable() → Kích hoạt.

Start() → Setup sau khi đã bật.

Update() → Làm việc liên tục.

Đây là hàng auto-run của Unity, không gọi cũng tự động xuất hiện. Muốn hiểu cách Unity vận hành từ trong ra ngoài thì phải hiểu mấy callback kiểu này là căn bản nhất.

Muốn tôi giải thích theo kiểu flow chạy của một scene trong Unity không? Vẽ sơ đồ hay kể như truyện cũng được luôn á.

## 2. Kể Tên 5 Loại Giải Thuật Sắp Xếp Khác Nhau => Sort.md

## 3. Dùng Một Giải Thuật Sắp Xếp Khác Để Thay Cho Giải Thuật Trong Buổi Học => Sort.md

## 4. Thực Hiện Random Cho Current HP => #4 đến #9 mình làm trong scripts

- Sử dụng code để thực hiện random cho giá trị **Current HP** của nhân vật hoặc đối tượng trong game. -.

## 5. Tìm Enemy Có Current HP Nhỏ Nhất

- Viết code tìm đối tượng enemy có **Current HP** nhỏ nhất trong danh sách enemy.

## 6. Tìm Enemy Có Current HP Lớn Nhất

- Viết code tìm đối tượng enemy có **Current HP** lớn nhất trong danh sách enemy.

## 7. Bài Tập Về If Để Thực Hành

- Đọc IFStatementPractices.md

## 8. Bài Tập Về Foreach Để Thực Hành

- Đọc ForeachPractices.md

## 9. Bài Tập Về For Để Thực Hành

- Đọc ForPractices.md
