
# SUBWAY SUFFER 

Tiêu đề vắn tắt dự án

**Thành viên nhóm:**
Liệt kê thành viên nhóm phát triển dự án
- Trần Duy Thành - 21001584
- Nguyễn Trung Thông - 21001589
- Đỗ Thị Trang – 21001591
- Nguyễn Hữu Tần – 21001582
- Chu Minh Ngọc - 21001570
# 1. Mô tả game
Trò chơi "Subway Runner" là một trải nghiệm chạy đường tàu, điều kiển nhân vật chạy trốn khỏi bảo vệ. Người chơi sẽ đua trên các đoạn đường tàu điện ngầm đầy nguy hiểm, tránh va chạm với các tàu, vật cản và những trở ngại khác. Họ cần thu thập đồng xu, hoàn thành các nhiệm vụ phức tạp và tìm cách duy trì tốc độ để không bị bắt kịp thời gian hoặc bị loại khỏi trò chơi. Sự nhanh nhẹn và phản ứng nhanh nhạy là chìa khóa để vượt qua mỗi cấp độ và đạt được điểm số cao. Ngoài ra game còn có rất nhiều nhân vật, vật phẩm hỗ trợ và đặc biệt là so điểm với bạn bè.
## 1.1. Các kịch bản chơi game
* Game goal: Chạy, kiếm nhiều vàng để mở khóa tất cả nhân vật, mua các vật phẩm hỗ trợ để đạt được điểm càng cao càng tốt.
* Objectives:
  - Victory objective : không thực sự có (tự tạo cho bản thân 1 mục tiêu : mở khóa hết nhân vật; đạt điểm cao nhất thế giới;...)
  - Progression Objectives : các nhiệm vụ, thử thách, các dấu mốc nhỏ trong trò chơi.
  - Beneficial Objectives : ăn vàng hoặc hoàn thành nhiệm vụ, thử thách để có các vật phẩm giúp ích cho quá trình chơi.
  - Challenge Objectives : những thứ khó hoàn thành trong trò chơi.
* Các khu vực nhân vật chạy và khám phá:
  - Ai cập cổ: Cảnh quan với các kim tự tháp, sa mạc, và những di tích cổ xưa.
  - Ngoại ô thành phố: Khu vực ngoại ô với các nhà cửa, công viên và đường phố nhỏ.
  - Cầu: Chạy trên một chiếc cầu sắt bắc qua sông.
  - Nhà ga xe lửa: Gần các nhà ga với các đoạn đường tàu và tàu hỏa chạy qua.
  - Thành phố: Khu vực trung tâm với những tòa nhà cao tầng và xe bus.
  - Bãi biển: Cảnh đẹp với cát trắng, biển xanh.

## 1.2. Các usecase trong game
  **1. Chạy và né tránh:**
  - Mô tả: Nhân vật chạy liên tục trên các đoạn đường tàu điện ngầm, di chuyển qua các làn đường để tránh va chạm với các vật cản và tàu hỏa.
  - Hành động: Người chơi di chuyển nhân vật sang trái/phải hoặc nhảy để né tránh các chướng ngại vật.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/283fa726-23e3-4358-9aa6-01a795c3a34b)
  **2. Thu thập vàng và vật phẩm:**
  - Mô tả: Nhân vật phải thu thập vàng và các vật phẩm hỗ trợ như ván trượt, nam châm để giúp trong việc thu thập vàng hoặc vượt qua chướng ngại vật.
  - Hành động: Người chơi điều khiển nhân vật để nhặt vàng và các vật phẩm xuất hiện trên đường.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/efc6f726-eea2-4e64-a47d-14aed5a03181)
  **3. Mở Khóa Nhân Vật và Mua Vật Phẩm:**
  - Mô tả: Người chơi có thể sử dụng vàng để mở khóa nhân vật mới hoặc mua các vật phẩm hỗ trợ như ván trượt từ cửa hàng trong game.
  - Hành động: Người chơi sử dụng vàng tích lũy được để mua nhân vật hoặc vật phẩm từ cửa hàng.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/80c55c0f-6f1a-4cfb-9be2-89186277903a)
  **4. Cài Đặt và Tuỳ Chỉnh:**
  - Mô tả: Người chơi có thể điều chỉnh cài đặt như bật/tắt nhạc nền, âm thanh, thay đổi ngôn ngữ hoặc thay đổi độ nhạy của game.
  - Hành động: Người chơi thực hiện các tuỳ chọn trong phần cài đặt của game.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/1d3ae79d-2762-47ab-a961-324c33627b83)
  **5. Chơi Theo Nhóm và Đua Top Điểm:**
  - Mô tả: Có thể kết nối với bạn bè qua mạng xã hội để thách đấu với họ và cùng nhau chơi trong chế độ nhiều người chơi (online) hoặc so điểm.
  - Hành động: Người chơi kết nối với mạng xã hội hoặc chơi cùng bạn bè qua các chế độ nhiều người chơi.
    ![image](https://github.com/thoongnt/se7.3/assets/148628352/c45df068-4d7c-4c1b-92dd-a3f0cf56fdbe)



# 2. Các sửa đổi cho game
Mô tả chi tiết các sửa đổi trong game, bao gồm hình ảnh, thuyết minh, thuật toán hoặc các Class hay method thêm/sửa/xóa
## 2.1. Tắt box tìm đối thủ
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/37f366b7-2775-4696-b03d-2c0c466d1a78)  
  Trong game, box tìm đối thủ được quản lý bởi một đối tượng gọi là AutoFindOpponentsBox. Trong AutoFindOpponentsBox, có một script được gọi là DeactiveMessageBox.cs, đây chịu trách nhiệm điều khiển hiển thị và ẩn đi box thông báo trạng thái.
  ![image](https://github.com/thoongnt/se7.3/assets/148628352/d6a6c1d4-1653-49a2-915b-4b17976b73f9) ![image](https://github.com/thoongnt/se7.3/assets/148628352/89909d0e-48b0-402d-ab2e-9aa6cb6fc11c)  
Để tắt box thông qua việc nhấn nút ButtonClose, ta cần thêm một hàm mới, chẳng hạn như ButtonCloseMessage(). Hàm này được liên kết với nút ButtonClose và khi được gọi, nó sẽ thực hiện hành động tắt box hiển thị trạng thái bằng cách tương tác với DeactiveMessageBox.cs. Điều này giúp người chơi đóng box một cách dễ dàng khi cần thiết.    
![image](https://github.com/thoongnt/se7.3/assets/148628352/dfb649dc-3957-4c6d-a359-b654587f536c) ![image](https://github.com/thoongnt/se7.3/assets/148628352/248fd586-4bc9-42d0-8172-8c13c6872ef5)  
Hàm này được kích hoạt khi người dùng nhấn vào nút đóng (ButtonClose) trên hộp thoại. Đầu tiên, nó chạy một âm thanh thông báo việc nhấn nút (Module.PlayAudioClipFree). Sau đó, nó sử dụng một Animator để chơi một trigger animation ("TriClose") trên đối tượng này. Điều này thường được sử dụng để kích hoạt một hoạt ảnh đóng hộp thoại.


## 2.2. Thay đổi 2

# 3. Hướng dẫn Khởi tạo dự án
## 3.1. Cài Unity bản từ 2022 trở đi
Đăng ký tài khoản Unity bằng account sinh viên để có thể tham gia chương trình Education License của Unity

## 3.2. Mở dự án trên Unity và chạy thử ngay trên Màn hình Unity Editor
Vào menu File-> Open Scene, chọn vào file Assets/Scene/LoadData.unity
Bấm nút Play của Unity để chạy thử

## 3.3. Build và chạy trên Android

Vào menu File -> Build Settings, chọn Platform là Android rồi nhấn "Switch Platform" để chuyển sang Android. Sau đó nhấn vào nút Build để thực hiện build ra file APK. Tham khảo trên Google search để biết cách cài đặt Build settings sao cho phù hợp
