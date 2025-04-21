# Sử Dụng NavMesh Obstacle Trong Unity

## Hỏi AI: Cách Sử Dụng NavMesh Obstacle

### NavMesh Obstacle là gì?

**NavMesh Obstacle** là một thành phần trong Unity được sử dụng để tạo ra các vật cản trong môi trường, ngăn cản các nhân vật hoặc đối tượng điều hướng (navigation) qua những khu vực nhất định. Đối tượng được gắn **NavMesh Obstacle** sẽ trở thành vật cản và có thể tĩnh hoặc động, tùy thuộc vào cách bạn cấu hình nó.
NavMeshObstacle là một thành phần trong Unity dùng để mô phỏng các chướng ngại vật mà nhân vật điều hướng (NavMeshAgent) cần phải tránh khi di chuyển trên NavMesh. Đây là một công cụ rất hữu ích khi bạn muốn mô phỏng các vật thể di chuyển, rào chắn tạm thời hoặc các vật thể có thể xuất hiện và biến mất trong thế giới game.

Dưới đây là phần tổng hợp thực tế và súc tích về cách sử dụng NavMeshObstacle trong Unity – phục vụ cho mục đích học tập và phát triển dự án:

I. Mục đích sử dụng
NavMeshObstacle dùng để định nghĩa những chướng ngại vật mà hệ thống điều hướng (NavMesh) cần tránh. Thường áp dụng cho:

Vật thể đứng yên (thùng, tường tạm thời, v.v.)

Vật thể có thể di chuyển (cửa, xe, thang máy...)

II. Các bước cơ bản để sử dụng
1. Thêm NavMeshObstacle
Chọn GameObject trong Hierarchy.

Nhấn Add Component.

Tìm và thêm NavMeshObstacle.

2. Cấu hình thông số

Thuộc tính	Ý nghĩa	Gợi ý
Carve	Khi bật, vật thể sẽ đục "lỗ" trên NavMesh để agent tránh.	Nên bật nếu vật di chuyển.
Carve Only Stationary	Chỉ carve khi vật thể đứng yên.	Tắt nếu vật di chuyển liên tục.
Shape	Hình dạng chướng ngại (Box hoặc Capsule).	Chọn theo hình thực tế.
Size / Radius / Height	Kích thước vùng cản trở.	Cần khớp với collider.
III. Ví dụ thực tế
Tình huống: Cánh cửa mở ra khi nhân vật đến gần, đóng lại khi đi xa.
Mã mẫu:


using UnityEngine;
using UnityEngine.AI;

public class DoorObstacle : MonoBehaviour
{
    public NavMeshObstacle obstacle;

    public void OpenDoor()
    {
        obstacle.enabled = false; // Cho phép agent đi qua
        // Thêm animation nếu cần
    }

    public void CloseDoor()
    {
        obstacle.enabled = true;  // Ngăn đường
        // Thêm animation nếu cần
    }
}
Lưu ý: Nếu sử dụng animation, có thể kết hợp thêm với trigger hoặc sự kiện.

IV. Chướng ngại vật di chuyển được
Nếu có vật thể liên tục di chuyển và vẫn cần chặn đường:

Bật Carve.

Tắt Carve Only Stationary.

Ví dụ: xe đẩy di chuyển, robot, hoặc các vật thể xuất hiện – biến mất.

V. Một vài lưu ý quan trọng
NavMeshObstacle không tương thích trực tiếp với NavMeshAgent trên cùng một GameObject.

Tránh việc liên tục enable/disable quá nhanh (ảnh hưởng hiệu suất).

Nếu vật thể không bao giờ di chuyển, có thể bake trực tiếp lên NavMesh bằng cách gán layer Static và bỏ NavMeshObstacle.

Cần ví dụ đầy đủ hơn (có hoạt ảnh, trigger, hoặc tích hợp với AI)? Có thể yêu cầu cụ thể tình huống sử dụng để triển khai mã chi tiết hơn.