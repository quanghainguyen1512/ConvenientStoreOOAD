# Helpers

Project này chứa các class và các hàm hỗ trợ cho việc mapping giữa DAO và DTO, hoặc validate các property của DTO có hợp lệ không  

- MappingHelper: có 2 class
    - <b>MappingProfile</b> có tác dụng để khởi tạo Profile để sử dụng package AutoMapper ánh xạ giữa các class. Các bộ ánh xạ được định nghĩa trong <b>constructor</b> của MappingProfile. Các property cùng tên sẽ tự động ánh xạ, nếu muốn convert từ một hay nhiều property từ source class đến một property trong destination class. Ví dụ khi muốn ánh xạ từ class Customer (DAO) sang CustomerDto:
    ```csharp
    CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Age,
                    opt => opt.MapFrom(src => DateOfBirthToAge(src.DateOfBirth)))
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Gender,
                    opt => opt.MapFrom(src => src.Gender == true ? "Nam" : "Nu"));
    ```
    - <b>Mapping</b> là một class singleton, thực hiện lệnh ánh xạ hoặc convert các thuộc tính giữa các class, ở đây cụ thể là giữa DTO và DAO. Sử dụng: (tham khảo Project DemoOnConsole)
    ```csharp
    var cusdto = Mapping.Mapper.Map<CustomerDto>(cus);
    ```
     