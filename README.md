# DBMS_MonAn

Đồ án về môn hệ quản trị cơ sở dữ liệu																							 		Phần mềm quản lý món ăn

Phần mềm này giúp cho việc quản lý các món ăn dễ dàng hơn, bên cạnh đó là quản lý nhân viên, khách hàng. Ngoài ra còn là nơi trao đổi các công thức món ăn với nhau

Công nghệ sử dụng: ADO.net, bunifu framework UI, ngôn ngữ C#

Đối với SQL thì có sử dụng store procedure cho việc thêm sửa xoá tìm kiếm, trigger và transaction dùng để xử lý các ràng buộc, view trích một phần nội dung cho người dùng xem

Sừ dụng phần mềm:

I.	Màn hình trang chủ

•	Khi mở phần mềm thì sẽ hiện ra trang chủ như hình bên dưới:

•	Ở đây có 3 nút là Đăng nhập, đổi mật khẩu, thoát

![image](https://user-images.githubusercontent.com/44945415/144164844-102c9a5c-c807-4b3f-8e32-7ec3149f9a46.png)

II.	Đăng nhập

•	Sau khi chọn đăng nhập thì trang đăng nhập hiện ra

•	Tại đây, có hai loại tài khoản là admin và nhân viên

•	Khi đăng nhập vào sẽ chạy ra trang quản lý các chức năng chương trình

![image](https://user-images.githubusercontent.com/44945415/144164935-71cf9202-7af0-474e-90b0-741c555d2cb3.png)

III.	Đổi mật khẩu
•	Ở mục này tài khoản được cấp thì mỗi người có thể được phép đổi mật khảu theo ý mình muốn

![image](https://user-images.githubusercontent.com/44945415/144164969-66374819-60a4-4dd7-9956-51167f89e228.png)

IV.	Trang quản lý

•	Sau khi đăng nhập thành công thì ta có thể lựa chọn các chương trình cho sản phẩm

•	Nếu đăng nhập bằng tài khoản admin thì phần cá nhân sử dụng được, ngược lại sẽ bị ẩn

![image](https://user-images.githubusercontent.com/44945415/144165266-8d758367-12f2-4c89-bb77-f59906fdb767.png)

![image](https://user-images.githubusercontent.com/44945415/144165288-013af9d1-79a9-421f-8638-32ed94d0de21.png)

V.	Trang tài khoản

•	Tại trang tài khoản là nơi admin sẽ có quyền được tạo, xoá tài khoản theo yêu cầu

![image](https://user-images.githubusercontent.com/44945415/144165346-2941d1fd-719c-4932-a9c8-4bd0767c8671.png)

VI.	Trang khách hàng

•	Trang này dùng để quản lý khách hàng với mục đích để xem khách hàng nào là khách hàng quý của cửa hàng thông qua việc tới quán ăn nhiều sẽ được lưu lại 

![image](https://user-images.githubusercontent.com/44945415/144165362-b8fcad60-29b7-481f-92c4-365ededf7b1a.png)

VII.	Trang nhân viên

•	Trang này dùng với mục đích để kiểm soát nhân viên cnf đi làm hay nghỉ

![image](https://user-images.githubusercontent.com/44945415/144165390-91fc3561-b26b-4080-945f-799a924bea4c.png)

VIII.	Trang món ăn

•	Dùng để tra cứu món ăn, nguồn gốc và giá cả các món ăn của quán

![image](https://user-images.githubusercontent.com/44945415/144165411-a50f565f-a70c-41c9-9d71-6351e419278f.png)

IX.	Trang nguyên liệu

•	Trang này cho biết được nguyên liệu của món ăn

![image](https://user-images.githubusercontent.com/44945415/144165428-f0ac9bfd-412b-4166-ba1e-562ec99f391b.png)

![image](https://user-images.githubusercontent.com/44945415/144165439-b850ff0b-4fb3-4894-8fa8-913d7169a4c5.png)

XI.	Trang công thức

•	Tại đây nhân viên quán hay đầu bếp có thể tự mình thêm công thức món ăn để cùng nhau trao đổi món, hoặc là nơi để các đầu bếp mới cơ thể học nấu những món ăn của quán

![image](https://user-images.githubusercontent.com/44945415/144165462-ea8deb47-d385-471e-84ef-ddc1571c1935.png)

XII.	Trang đặt món

•	Khi khách hàng vào thì nhân viên sẽ chọn mục đặt món để có thể đặt món cho khách hàng

•	Khi khách hàng ra về thì thanh toán có phần nút in sẽ tự động in ra hoá đơn

![image](https://user-images.githubusercontent.com/44945415/144165505-7d1129d3-1c15-44c1-9a62-5599893d939e.png)

XIII.	Trang đánh giá

•	Phần này để xem được nhân viên nào làm việc hiệu quả, hay xem cụ thể công thức nấu, nguồn gốc món ăn, hay là số tiền của khách hàng

![image](https://user-images.githubusercontent.com/44945415/144165529-5e60cf17-4591-4ec8-a059-03a87d6ab178.png)

XIV.	Thống kê

•	Nơi xem những thống kê món ăn theo ngày và có trực quan hoá dữ liệu để xem thử món ăn nào bán chạy

![image](https://user-images.githubusercontent.com/44945415/144165552-4ca6f4e3-8fe6-41b5-9930-145b50f64e3a.png)

XV.	Địa điểm

•	Nơi tra cứu địa điểm của các món ăn đó (bánh mì sẽ có ở đâu bán)

![image](https://user-images.githubusercontent.com/44945415/144165581-3b10692c-e3e9-40ab-aa5b-94a4d4ba9a1d.png)









