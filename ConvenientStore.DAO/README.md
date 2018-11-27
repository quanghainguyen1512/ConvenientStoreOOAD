# Data Access Objects
Project này chứa các class DAO (Entities) để map thằng vào database  
Tớ đã implement sẵn các class, sau này thêm column nào bên database thì vô đây thêm property thôi.   

## Lưu ý về các Attributes:  
- <b>[Key]</b> để đánh dấu property nào là <b>khóa chính</b> của class đó, có 2 option là [Key] và [ExplicitKey].  
  - [Key] được áp dụng cho các khóa mà sẽ được <b>generate</b> trong database (ví dụ như Auto Increment).
  - [ExplicitKey] dùng ở trường hợp ngược lại, tức là các khóa được gán thủ công khi thêm row mới. Trong đồ án mình để đơn giản thì không đụng tới cái này.
- <b>[Write(false)]</b>: Attribute này để đánh dấu các property sẽ được bỏ qua khi thao tác Thêm hay Sửa.