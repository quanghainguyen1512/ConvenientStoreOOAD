using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Helpers.Message
{
    public class MessageContent
    {
        public static string REQUIRE_REINPUT_FIELD = "Vui lòng nhập lại thông tin";

        public static string BREAK_LINE = "\r\n";

        public static string GET_CUSTOMER_ERROR = "Không tìm thấy thông tin khách hàng";

        public static string GET_PRODUCT_ERROR = "Không tìm thấy thông tin sản phẩm";

        public static string PRODUCT_CODE_IS_EMPTY = "[Mã sản phẩm] trống";

        public static string PRODUCT_QUANTITY_IS_EMPTY = "[Số lượng] trống";

        public static string SUBMIT_BILL_ERROR = "Lỗi phát sinh khi thanh toán";

        public static string UPDATE_CUSTOMER_INFO_ERROR = "Lỗi khi cập nhật dữ liệu người dùng: {0}";

        public static string UPDATE_PRODUCT_DETAIL_ERROR = "Lỗi khi cập nhật thông tin sản phẩm: {0}";

        public static string SYSTEM_ERROR = "Không thể lấy dữ liệu";

        public static string ADD_BILL_ERROR = "Lỗi khi thêm hóa đơn";
    }
}
