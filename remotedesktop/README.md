Thành Viên: * Võ Lê Vũ - 20522170
            * Phạm Kiên - 20521490


# Remote Desktop Application
Dự án bao gồm một ứng dụng chia sẻ màn hình đơn giản với kiến trúc server-client. Server lắng nghe các kết nối từ client và nhận các hình ảnh màn hình, trong khi client kết nối tới server và gửi các hình ảnh màn hình của nó.

## Tổng Quan

Ứng dụng này minh họa một cơ chế chia sẻ màn hình cơ bản sử dụng Windows Forms và .NET Framework. Server chấp nhận kết nối từ client và hiển thị các hình ảnh màn hình của client theo thời gian thực. Client chụp màn hình của nó và gửi các hình ảnh đến server.


## Nội Dung Thực Hiện

Ứng dụng này có các chức năng chính sau:

- **Server**:
  - Lắng nghe các kết nối từ client qua cổng được chỉ định.
  - Nhận và hiển thị hình ảnh màn hình từ client theo thời gian thực.
  - Dừng lắng nghe và kết thúc các kết nối khi ứng dụng đóng.

- **Client**:
  - Kết nối tới server qua địa chỉ IP và cổng được chỉ định.
  - Gửi hình ảnh màn hình hiện tại đến server theo chu kỳ định kỳ (sử dụng `timer`).
  - Bắt đầu và dừng việc chia sẻ màn hình theo yêu cầu của người dùng.
## Sử Dụng

1. Xây dựng và chạy dự án `server`.
    - Mở giải pháp `server` trong Visual Studio.
    - Đặt số cổng trong textbox `txtPort`.
    - Nhấn nút `Listen` để khởi động server.

2. Xây dựng và chạy dự án `client`.
    - Mở giải pháp `client` trong Visual Studio.
    - Nhập địa chỉ IP của server và số cổng vào các textbox `txtIP` và `txtPort` tương ứng.
    - Nhấn nút `Connect` để kết nối tới server.
    - Sau khi kết nối thành công, nhấn nút `Share My Screen` để bắt đầu chia sẻ màn hình.


### Server

- `Form1.cs`: Form chính của ứng dụng server. Cho phép thiết lập số cổng và khởi động server.
- `Form2.cs`: Form phụ chịu trách nhiệm lắng nghe các kết nối từ client và nhận hình ảnh.

### Client

- `Form1.cs`: Form chính của ứng dụng client. Chịu trách nhiệm kết nối tới server và gửi hình ảnh màn hình.
