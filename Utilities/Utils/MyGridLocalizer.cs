using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Localization;

namespace BMS
{
    public class MyGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.FindControlFindButton)
                return "Tìm";
            if (id == GridStringId.FindControlClearButton)
                return "Bỏ";
            if (id == GridStringId.GridGroupPanelText)
                return "Kéo thả cột vào đây để gom nhóm";
            if (id == GridStringId.MenuColumnSortAscending)
                return "Sắp xếp tăng dần";
            if (id == GridStringId.MenuColumnSortDescending)
                return "Sắp xếp giảm dần";
            if (id == GridStringId.MenuColumnClearSorting)
                return "Bỏ sắp xếp";
            if (id == GridStringId.MenuColumnGroup)
                return "Gom nhóm theo cột này";
            if (id == GridStringId.MenuGroupPanelShow)
                return "Hiện hộp gom nhóm";
            if (id == GridStringId.MenuGroupPanelHide)
                return "Ẩn hộp gom nhóm";
            if (id == GridStringId.MenuGroupPanelFullExpand)
                return "Mở tất cả các nhóm";
            if (id == GridStringId.MenuGroupPanelFullCollapse)
                return "Thu tất cả các nhóm";
            if (id == GridStringId.MenuColumnUnGroup)
                return "Bỏ gom nhóm";
            if (id == GridStringId.MenuColumnRemoveColumn)
                return "Ẩn cột này";
            if (id == GridStringId.MenuColumnShowColumn)
                return "Hiện cột này";
            if (id == GridStringId.MenuColumnColumnCustomization)
                return "Tùy chỉnh cột";
            if (id == GridStringId.CustomizationCaption)
                return "Tùy chỉnh cột";            
            if (id == GridStringId.CustomizationFormColumnHint)
                return "Kéo và thả cột vào đây để tùy chỉnh";
            if (id == GridStringId.MenuColumnBestFit)
                return "Căn chỉnh";
            if (id == GridStringId.MenuColumnBestFitAllColumns)
                return "Căn chỉnh tất cả";
            if (id == GridStringId.MenuColumnFilterEditor)
                return "Cài đặt lọc";
            //if (id == GridStringId.MenuColumnFilter)
            //    return "menu filter";
            if (id == GridStringId.PopupFilterCustom)
                return "(Tùy chọn)";
            if (id == GridStringId.PopupFilterAll)
                return "(Tất cả)";
            if (id == GridStringId.FilterPanelCustomizeButton)
                return "Sửa lọc";
            if (id == GridStringId.FilterBuilderCaption)
                return "Cài đặt lọc";
            if (id == GridStringId.FilterBuilderOkButton)
                return "Đồng ý";
            if (id == GridStringId.FilterBuilderApplyButton)
                return "Áp dụng";
            if (id == GridStringId.FilterBuilderCancelButton)
                return "Hủy bỏ";
         
            if (id == GridStringId.MenuColumnAutoFilterRowShow)
                return "Hiện hàng lọc tự động";
            if (id == GridStringId.MenuColumnAutoFilterRowHide)
                return "Ẩn hàng lọc tự động";
            if (id == GridStringId.MenuColumnFilterMode)
                return "Chế độ lọc";
            if (id == GridStringId.MenuColumnFilterModeDisplayText)
                return "Văn bản";
            if (id == GridStringId.MenuColumnFilterModeValue)
                return "Giá trị";
            if (id == GridStringId.CustomFilterDialogCancelButton)
                return "Hủy bỏ";
            if (id == GridStringId.CustomFilterDialogCaption)
                return "Lọc tại cột:";          
            if (id == GridStringId.CustomFilterDialogEmptyOperator)
                return "(Chọn phép toán)";
            if (id == GridStringId.CustomFilterDialogEmptyValue)
                return "%giá trị%";
            if (id == GridStringId.CustomFilterDialogFormCaption)
                return "Tùy chọn lọc tự động";
            //if (id == GridStringId.CustomFilterDialogHint)
            //    return "fil hint";
            if (id == GridStringId.CustomFilterDialogOkButton)
                return "Đồng ý";
            if (id == GridStringId.CustomFilterDialogRadioAnd)
                return "Và";
            if (id == GridStringId.CustomFilterDialogRadioOr)
                return "Hoặc";
            //if (id == GridStringId.CustomFilterDialogConditionBlanks)
            //{
            //    return "Trống";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionEQU)
            //{
            //    return "=";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionGT)
            //{
            //    return ">";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionGTE)
            //{
            //    return ">=";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionLike)
            //{
            //    return "Chứa";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionLT)
            //{
            //    return "<";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionLTE)
            //{
            //    return "<=";
            //}           
            //if (id == GridStringId.CustomFilterDialogConditionNEQ)
            //{
            //    return "Khác";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionNonBlanks)
            //{
            //    return "Có dữ liệu";
            //}
            //if (id == GridStringId.CustomFilterDialogConditionNotLike)
            //{
            //    return "Không chứa";
            //}
            return base.GetLocalizedString(id);
        }
    }
}
