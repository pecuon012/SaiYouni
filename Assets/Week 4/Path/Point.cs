using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


public class Point : MonoBehaviour
{
    [SerializeField] protected Point nextpoint;
    public Point Nextpoint => nextpoint;

    // Start is called before the first frame update
    void Start()
    {
        LoadNextPoint();
    }
    protected virtual void LoadNextPoint()
    {
        //if (nextpoint == null) return;
        Transform parent = transform.parent; //Lấy transform cha của GameObject hiện tại.
        if (parent == null) return; //Nếu không có cha(tức là bị rơi lẻ loi), dừng lại luôn. một cách kiểm tra cực kỳ an toàn, tránh lỗi NullReference.
        int index = transform.GetSiblingIndex(); //Lấy vị trí của bản thân trong danh sách các con của cha.Ví dụ: nếu bạn là đứa thứ 2 thì index = 1(vì Unity đếm từ 0).
        int siblingCount = parent.childCount; //Đếm tổng số anh em(con của cha đó).Để biết giới hạn không vượt quá.

        if (index + 1 < siblingCount)
        {
            Transform nextTransform = parent.GetChild(index + 1); // nextTransform được lấy đối tượng nhờ vào thằng cha.getChild
            Point next = nextTransform.GetComponent<Point>(); // lấy đối tượng có component Point
            this.nextpoint = next;
        }
        // Nếu đã là điểm cuối cùng
    }

    // Update is called once per frame

}
