using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Localization;
using DevExpress.XtraTreeList.Localization;
using DevExpress.XtraLayout.Localization;


namespace BMS
{

    public class NVGridLocalizer : GridLocalizer
    {
        public override string Language { get { return "Vietnam"; } }
        public override string GetLocalizedString(GridStringId id)
        {
            switch (id)
            {
                case GridStringId.MenuColumnSortAscending: return "Sắp xếp tăng";
                case GridStringId.MenuColumnSortDescending: return "Sắp xếp giảm";
                case GridStringId.MenuColumnClearSorting: return "Không sắp xếp";
                case GridStringId.MenuColumnGroup: return "Nhóm cột";
                case GridStringId.MenuColumnUnGroup: return "Không nhóm";
                case GridStringId.MenuColumnGroupBox: return "Hiện thị cột được nhóm";
                case GridStringId.MenuColumnColumnCustomization: return "Điều chỉnh ẩn hiện cột";
                case GridStringId.MenuColumnFilterEditor: return "Tùy chọn lọc dữ liệu";
                case GridStringId.MenuColumnBestFit: return "Điều chỉnh kích thước cột";
                case GridStringId.MenuColumnFilter: return "Lọc dữ liệu";
                case GridStringId.MenuColumnClearFilter: return "Không lọc dữ liệu";
                case GridStringId.MenuColumnBestFitAllColumns: return "Điều chỉnh kích thước tất cả cột";
                case GridStringId.MenuColumnAutoFilterRowHide: return "Ẩn lọc dữ liệu";
                case GridStringId.MenuColumnAutoFilterRowShow: return "Hiển thị lọc dữ liệu";
                case GridStringId.MenuColumnRemoveColumn: return "Ẩn cột này";
                case GridStringId.MenuGroupPanelHide: return "Ẩn Gom Nhóm";
                case GridStringId.MenuGroupPanelShow: return "Hiển Thị Gom Nhóm";
                case GridStringId.MenuColumnFindFilterHide: return "Ẩn thanh tìm kiếm";
                case GridStringId.MenuColumnFindFilterShow: return "Hiển thị thanh tìm kiếm";
    
                case GridStringId.FilterBuilderCaption: return "Tùy chọn lọc dữ liệu";
                case GridStringId.FilterBuilderApplyButton: return "Chọn";
                case GridStringId.FilterBuilderCancelButton: return "Đóng";
                case GridStringId.FilterBuilderOkButton: return "Đồng ý";

                case GridStringId.GridGroupPanelText:
                   return "Kéo một tiêu đề cột vào đây để nhóm theo cột đó";
                case GridStringId.MenuFooterAverage: return "Trung bình";
                case GridStringId.MenuFooterCount: return "Đếm";
                case GridStringId.FindControlClearButton:
                    return "Hủy chọn";
                case GridStringId.FindControlFindButton:
                   return "Tìm kiếm";
                //case GridStringId.FindNullPrompt:
                //    return "Từ khóa";
                //case GridStringId.MenuColumnClearAllSorting:
                //    return "Hủy tất cả các sắp xếp";
                //case GridStringId.CustomFilterDialogCaption:
                //    return "Từ khóa 1";
                case GridStringId.FilterPanelCustomizeButton: return "Tùy chọn lọc dữ liệu";

                case GridStringId.GridNewRowText: return "Nhấn vào đây để thêm mới";

                case GridStringId.CustomizationCaption: return "Điều chỉnh ẩn hiện cột";
                case GridStringId.CustomizationBands: return "Nhóm cột";
                case GridStringId.CustomizationColumns: return "Cột";
                case GridStringId.CustomizationFormBandHint: return "Kéo thả nhóm muốn ẩn vào đây";
                case GridStringId.CustomizationFormColumnHint: return "Kéo thả cột muốn ẩn vào đây";
            }
            return base.GetLocalizedString(id);
        }


    }

    public class NVEditorsLocalizer : Localizer
    {
        public override string Language { get { return "Vietnam"; } }
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                case StringId.CalcError: return "Lỗi phép tính";

                case StringId.CaptionError: return "Lỗi";
                case StringId.CheckChecked: return "Đánh dấu chọn";
                case StringId.CheckIndeterminate: return "CheckIndeterminate";
                case StringId.CheckUnchecked: return "Không đánh dấu chọn";
                case StringId.ColorTabCustom: return "Điều chỉnh";
                case StringId.ColorTabSystem: return "Hệ thống";
                case StringId.ColorTabWeb: return "Web";
                case StringId.ContainerAccessibleEditName: return "ContainerAccessibleEditName";
                case StringId.DataEmpty: return "Dữ liệu trống";
                case StringId.DateEditClear: return "Clear";
                case StringId.DateEditToday: return "Hôm nay";
                case StringId.FilterClauseAnyOf: return "Bất kỳ của";
                case StringId.FilterClauseBeginsWith: return "Bắt đầu với";
                case StringId.FilterClauseBetween: return "Khoảng giữa";
                case StringId.FilterClauseBetweenAnd: return "Và";
                case StringId.FilterClauseContains: return "Chứa";
                case StringId.FilterClauseDoesNotContain: return "Không chứa";
                case StringId.FilterClauseDoesNotEqual: return "Khác";
                case StringId.FilterClauseEndsWith: return "Kết thúc bằng";
                case StringId.FilterClauseEquals: return "Bằng";
                case StringId.FilterClauseGreater: return "Lớn hơn";
                case StringId.FilterClauseGreaterOrEqual: return "Lớn hơn hoặc bằng";
                case StringId.FilterClauseIsNotNull: return "Khác rỗng";
                case StringId.FilterClauseIsNull: return "Bằng rỗng";
                case StringId.FilterClauseLess: return "Nhỏ hơn";
                case StringId.FilterClauseLessOrEqual: return "Nhỏ hơn hoặc bằng";
                case StringId.FilterClauseLike: return "Giống";
                case StringId.FilterClauseNoneOf: return "Is none of";
                case StringId.FilterClauseNotBetween: return "Nằm ngoài";
                case StringId.FilterClauseNotLike: return "Không giống";

                /*FilterCriteriaToString*/
                case StringId.FilterEmptyEnter: return "Nhập một giá trị";
                case StringId.FilterEmptyValue: return "Rỗng";
                case StringId.FilterGroupAnd: return "Và";
                case StringId.FilterGroupNotAnd: return "Không và";
                case StringId.FilterGroupNotOr: return "Không hoặc";
                case StringId.FilterGroupOr: return "Hoặc";
                case StringId.FilterMenuClearAll: return "Xóa tất cả";
                case StringId.FilterMenuConditionAdd: return "Thêm điều kiện";
                case StringId.FilterMenuGroupAdd: return "Thêm nhóm";
                case StringId.FilterMenuRowRemove: return "Xóa dòng";
                case StringId.FilterToolTipElementAdd: return "Thêm một phần tử vào danh sách";
                case StringId.FilterToolTipKeysAdd: return "(Sử dụng phím Insert trên bàn phím)";
                case StringId.FilterToolTipKeysRemove: return "(Sử dụng phím Delete trên bàn phím)";
                case StringId.FilterToolTipNodeAction: return "Hành động";
                case StringId.FilterToolTipNodeAdd: return "Thêm mới điều kiện vào nhóm";
                case StringId.FilterToolTipNodeRemove: return "Bỏ điều kiện này";
                case StringId.FilterToolTipValueType: return "So sánh với một giá trị";


                case StringId.ImagePopupEmpty: return "(Rỗng)";
                case StringId.ImagePopupPicture: return "(Ảnh)";
                case StringId.InvalidValueText: return "Giá trị không hợp lệ";
                case StringId.LookUpColumnDefaultName: return "Tên";
                case StringId.LookUpEditValueIsNull: return "";
                //case StringId.LookUpInvalidEditValueType
                case StringId.MaskBoxValidateError: return "Giá trị nhập vào chưa đúng. Bạn có muốn chỉnh sửa nó không?\r\n\r\nĐồng ý - quay lại editor và chỉnh sửa.\r\nKhông đồng ý - giữ nguyên giá trị.\r\nHủy - trở về giá trị trước khi sửa.\r\n ";

                case StringId.NavigatorTextStringFormat: return "Dòng {0} của {1}";
                case StringId.NavigatorAppendButtonHint: return "Thêm";
                case StringId.NavigatorCancelEditButtonHint: return "Không lưu";
                case StringId.NavigatorEditButtonHint: return "Sửa";
                case StringId.NavigatorRemoveButtonHint: return "Xóa";
                case StringId.NavigatorEndEditButtonHint: return "Lưu";
                case StringId.NavigatorFirstButtonHint: return "Dòng đầu";
                case StringId.NavigatorLastButtonHint: return "Dòng cuối";
                case StringId.NavigatorNextButtonHint: return "Dòng kế";
                case StringId.NavigatorPreviousButtonHint: return "Dòng trước";
                case StringId.NavigatorNextPageButtonHint: return "Trang kế";
                case StringId.NavigatorPreviousPageButtonHint: return "Trang trước";
                //case StringId.NotValidArrayLength
                case StringId.PictureEditMenuCut: return "Cắt";
                case StringId.PictureEditMenuCopy: return "Sao lưu";
                case StringId.PictureEditMenuPaste: return "Dán";
                case StringId.PictureEditMenuDelete: return "Xóa";
                case StringId.PictureEditMenuLoad: return "Nạp";
                case StringId.PictureEditMenuSave: return "Lưu";
                case StringId.PictureEditOpenFileError: return "Định dạng ảnh sai";
                case StringId.PictureEditOpenFileErrorCaption: return "Lỗi mở ảnh";
                case StringId.PictureEditOpenFileFilter: return
                                                                "Bitmap Files (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|JPEG" +
                                                                " File Interchange Format (*.jpg;*.jpeg)|*.jpg;*.jpeg|Icon Files (*.ico)|*.ico|All" +
                                                                " Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png;*.tif|All Files |*.*";
                case StringId.PictureEditOpenFileTitle: return "Nạp hình";
                //case StringId.PictureEditSaveFileFilter
                case StringId.PictureEditSaveFileTitle: return "Lưu mới";


                case StringId.TabHeaderButtonClose: return "Đóng";
                case StringId.TabHeaderButtonNext: return "Kế";
                case StringId.TabHeaderButtonPrev: return "Trước";

                case StringId.TextEditMenuCopy: return "Sao lưu";
                case StringId.TextEditMenuCut: return "Cắt";
                case StringId.TextEditMenuPaste: return "Dán";
                case StringId.TextEditMenuDelete: return "Xóa";
                case StringId.TextEditMenuSelectAll: return "Chọn tất cả";
                case StringId.TextEditMenuUndo: return "Quay lại";

                case StringId.UnknownPictureFormat: return "Không hiểu định dạng tập tin hình ảnh";

                case StringId.OK: return "Đồng ý";
                case StringId.Cancel: return "Đóng";

                case StringId.XtraMessageBoxAbortButtonText: return "Cảnh báo";//////
                case StringId.XtraMessageBoxCancelButtonText: return "Quay lại";
                case StringId.XtraMessageBoxIgnoreButtonText: return "Bỏ qua";
                case StringId.XtraMessageBoxNoButtonText: return "Không";
                case StringId.XtraMessageBoxOkButtonText: return "Đồng ý";
                case StringId.XtraMessageBoxRetryButtonText: return "Thử lại";
                case StringId.XtraMessageBoxYesButtonText: return "Đồng ý";
                // ...
            }
            return base.GetLocalizedString(id);
        }
    }

    public class NVPrintingLocalizer : PreviewLocalizer
    {
        	public override  string GetLocalizedString(PreviewStringId id) {
			string ret = "";
			switch(id) {
				case PreviewStringId.MenuItem_File:
					return "&File";
				case PreviewStringId.MenuItem_View:
					return "&View";
				case PreviewStringId.MenuItem_Background:
					return "&Background";
				case PreviewStringId.MenuItem_PageSetup:
					return "Page Set&up...";
				case PreviewStringId.MenuItem_Print:
					return "&Print...";
				case PreviewStringId.MenuItem_PrintDirect:
					return "P&rint";
				case PreviewStringId.MenuItem_Export:
					return "&Export To";
				case PreviewStringId.MenuItem_Send:
					return "Sen&d As";
				case PreviewStringId.MenuItem_Exit:
					return "E&xit";
				case PreviewStringId.MenuItem_ViewToolbar:
					return "&Toolbar";
				case PreviewStringId.MenuItem_ViewStatusbar:
					return "&Statusbar";
				case PreviewStringId.MenuItem_ViewContinuous:
					return "&Continuous";
				case PreviewStringId.MenuItem_ViewFacing:
					return "&Facing";
				case PreviewStringId.MenuItem_BackgrColor:
					return "&Color...";
				case PreviewStringId.MenuItem_Watermark:
					return "&Watermark...";
				case PreviewStringId.MenuItem_PdfDocument:
					return "PDF File";
				case PreviewStringId.MenuItem_HtmDocument:
					return "HTML File";
				case PreviewStringId.MenuItem_MhtDocument:
					return "MHT File";
				case PreviewStringId.MenuItem_RtfDocument:
					return "RTF File";
				case PreviewStringId.MenuItem_XlsDocument:
					return "Excel File";
				case PreviewStringId.MenuItem_CsvDocument:
					return "CSV File";
				case PreviewStringId.MenuItem_TxtDocument:
					return "Text File";
				case PreviewStringId.MenuItem_GraphicDocument:
					return "Image File";
				case PreviewStringId.MenuItem_ZoomPageWidth:
					return "Page Width";
				case PreviewStringId.MenuItem_ZoomTextWidth:
					return "Text Width";
				case PreviewStringId.MenuItem_ZoomWholePage:
					return "Whole Page";
				case PreviewStringId.MenuItem_ZoomTwoPages:
					return "Two Pages";
				case PreviewStringId.MenuItem_PageLayout:
					return "&Page Layout";
				case PreviewStringId.Button_Cancel:
					return "Cancel";
				case PreviewStringId.Button_Ok:
					return "OK";
				case PreviewStringId.Button_Help:
					return "Help";
				case PreviewStringId.Button_Apply:
					return "Apply";
				case PreviewStringId.PreviewForm_Caption:
					return "Preview";
				case PreviewStringId.TB_TTip_Customize:
					return "Customize";
				case PreviewStringId.TB_TTip_Print:
					return "Print";
				case PreviewStringId.TB_TTip_PrintDirect:
					return "Quick Print";
				case PreviewStringId.TB_TTip_PageSetup:
					return "Page Setup";
				case PreviewStringId.TB_TTip_Magnifier:
					return "Magnifier";
				case PreviewStringId.TB_TTip_ZoomIn:
					return "Zoom In";
				case PreviewStringId.TB_TTip_ZoomOut:
					return "Zoom Out";
				case PreviewStringId.TB_TTip_Zoom:
					return "Zoom";
				case PreviewStringId.TB_TTip_Search:
					return "Search";
				case PreviewStringId.TB_TTip_FirstPage:
					return "First Page";
				case PreviewStringId.TB_TTip_PreviousPage:
					return "Previous Page";
				case PreviewStringId.TB_TTip_NextPage:
					return "Next Page";
				case PreviewStringId.TB_TTip_LastPage:
					return "Last Page";
				case PreviewStringId.TB_TTip_MultiplePages:
					return "Multiple Pages";
				case PreviewStringId.TB_TTip_Backgr:
					return "Background";
				case PreviewStringId.TB_TTip_Close:
					return "Close Preview";
				case PreviewStringId.TB_TTip_EditPageHF:
					return "Header And Footer";
				case PreviewStringId.TB_TTip_HandTool:
					return "Hand Tool";
				case PreviewStringId.TB_TTip_Export:
					return "Export Document...";
				case PreviewStringId.TB_TTip_Send:
					return "Send via E-Mail...";
				case PreviewStringId.TB_TTip_Map:
					return "Document Map";
				case PreviewStringId.TB_TTip_Watermark:
					return "Watermark";
				case PreviewStringId.TB_TTip_Scale:
					return "Scale";
				case PreviewStringId.TB_TTip_Open:
					return "Open a document";
				case PreviewStringId.TB_TTip_Save:
					return "Save the document";
				case PreviewStringId.SB_TotalPageNo:
					return "Total Pages:";
				case PreviewStringId.SB_CurrentPageNo:
					return "Current Page:";
				case PreviewStringId.SB_ZoomFactor:
					return "Zoom Factor:";
				case PreviewStringId.SB_PageNone:
					return "none";
				case PreviewStringId.SB_PageInfo:
					return "{0} of {1}";
				case PreviewStringId.Msg_EmptyDocument:
					return "The document does not contain any pages.";
				case PreviewStringId.Msg_CreatingDocument:
					return "Creating the document...";
				case PreviewStringId.MPForm_Lbl_Pages:
					return "Pages";
				case PreviewStringId.Msg_UnavailableNetPrinter:
					return "The net printer is unavailable.";
				case PreviewStringId.Msg_NeedPrinter:
					return "No printers installed.";
				case PreviewStringId.Msg_WrongPrinter:
					return "The printer name is invalid. Please check the printer settings.";
				case PreviewStringId.Msg_WrongPrinting:
					return "An error occurred during printing a document.";
				case PreviewStringId.Msg_WrongPageSettings:
					return "The current printer doesn't support the selected paper size.\r\nProceed with printing anyway?";
				case PreviewStringId.Msg_CustomDrawWarning:
					return "Warning!";
				case PreviewStringId.Msg_PageMarginsWarning:
					return "One or more margins are set outside the printable area of the page. Continue?";
				case PreviewStringId.Margin_Inch:
					return "Inch";
				case PreviewStringId.Msg_IncorrectPageRange:
					return "This is not a valid page range";
				case PreviewStringId.Msg_FontInvalidNumber:
					return "The font size cannot be set to zero or a negative number";
				case PreviewStringId.Msg_NotSupportedFont:
					return "This font is not yet supported";
				case PreviewStringId.Msg_IncorrectZoomFactor:
					return "The number must be beetween {0} and {1}.";
				case PreviewStringId.Msg_InvalidMeasurement:
					return "This is not a valid measurement.";
				case PreviewStringId.Msg_CannotAccessFile:
					return "The process cannot access the file \"{0}\" because it is being used by another process.";
				case PreviewStringId.Msg_FileReadOnly:
					return "File \"{0}\" is set to read-only, try again with a different file name.";
				case PreviewStringId.Msg_OpenFileQuestion:
					return "Do you want to open this file?";
				case PreviewStringId.Msg_OpenFileQuestionCaption:
					return "Export";
				case PreviewStringId.Msg_CantFitBarcodeToControlBounds:
					return "Control's boundaries are too small for the barcode";
				case PreviewStringId.Msg_InvalidBarcodeText:
					return "There are invalid characters in the text";
				case PreviewStringId.Msg_InvalidBarcodeTextFormat:
					return "Invalid text format";
				case PreviewStringId.Msg_SearchDialogFinishedSearching:
					return "Finished searching through the document";
				case PreviewStringId.Msg_SearchDialogTotalFound:
					return "Total found: ";
				case PreviewStringId.Msg_SearchDialogReady:
					return "Ready";
				case PreviewStringId.Msg_NoDifferentFilesInStream:
					return "A document can't be exported to a stream in the DifferentFiles mode. Use the SingleFile or SingleFilePageByPage mode instead.";
				case PreviewStringId.Msg_BigFileToCreateJPEG:
					return "The output file is too big to create a JPEG file. Please choose another image format or another export mode.";
				case PreviewStringId.Msg_BigBitmapToCreate:
					return "The output file is too big. Please try to reduce the image resolution,\r\nor choose another export mode.";
				case PreviewStringId.Msg_XlsMoreThanMaxRows:
					return "The created XLS file is too big for the XLS format, because it contains more than 65536 rows.\r\nPlease try to reduce the amount of rows in your report and export the report to XLS again.";
				case PreviewStringId.Msg_XlsMoreThanMaxColumns:
					return "The created XLS file is too big for the XLS format, because it contains more than 256 columns.\r\nPlease try to reduce the amount of columns in your report and export the report to XLS again.";
				case PreviewStringId.Margin_Millimeter:
					return "mm";
				case PreviewStringId.Margin_TopMargin:
					return "Top Margin";
				case PreviewStringId.Margin_BottomMargin:
					return "Bottom Margin";
				case PreviewStringId.Margin_LeftMargin:
					return "Left Margin";
				case PreviewStringId.Margin_RightMargin:
					return "Right Margin";
				case PreviewStringId.ScrollingInfo_Page:
					return "Page";
				case PreviewStringId.WMForm_PictureDlg_Title:
					return "Select Picture";
				case PreviewStringId.WMForm_ImageStretch:
					return "Stretch";
				case PreviewStringId.WMForm_ImageClip:
					return "Clip";
				case PreviewStringId.WMForm_ImageZoom:
					return "Zoom";
				case PreviewStringId.WMForm_Watermark_Asap:
					return "ASAP";
				case PreviewStringId.WMForm_Watermark_Confidential:
					return "CONFIDENTIAL";
				case PreviewStringId.WMForm_Watermark_Copy:
					return "COPY";
				case PreviewStringId.WMForm_Watermark_DoNotCopy:
					return "DO NOT COPY";
				case PreviewStringId.WMForm_Watermark_Draft:
					return "DRAFT";
				case PreviewStringId.WMForm_Watermark_Evaluation:
					return "EVALUATION";
				case PreviewStringId.WMForm_Watermark_Original:
					return "ORIGINAL";
				case PreviewStringId.WMForm_Watermark_Personal:
					return "PERSONAL";
				case PreviewStringId.WMForm_Watermark_Sample:
					return "SAMPLE";
				case PreviewStringId.WMForm_Watermark_TopSecret:
					return "TOP SECRET";
				case PreviewStringId.WMForm_Watermark_Urgent:
					return "URGENT";
				case PreviewStringId.WMForm_Direction_Horizontal:
					return "Horizontal";
				case PreviewStringId.WMForm_Direction_Vertical:
					return "Vertical";
				case PreviewStringId.WMForm_Direction_BackwardDiagonal:
					return "BackwardDiagonal";
				case PreviewStringId.WMForm_Direction_ForwardDiagonal:
					return "ForwardDiagonal";
				case PreviewStringId.WMForm_VertAlign_Bottom:
					return "Bottom";
				case PreviewStringId.WMForm_VertAlign_Middle:
					return "Middle";
				case PreviewStringId.WMForm_VertAlign_Top:
					return "Top";
				case PreviewStringId.WMForm_HorzAlign_Left:
					return "Left";
				case PreviewStringId.WMForm_HorzAlign_Center:
					return "Center";
				case PreviewStringId.WMForm_HorzAlign_Right:
					return "Right";
				case PreviewStringId.WMForm_ZOrderRgrItem_InFront:
					return "In &front";
				case PreviewStringId.WMForm_ZOrderRgrItem_Behind:
					return "&Behind";
				case PreviewStringId.WMForm_PageRangeRgrItem_All:
					return "&All";
				case PreviewStringId.WMForm_PageRangeRgrItem_Pages:
					return "&Pages:";
				case PreviewStringId.SaveDlg_FilterPdf:
					return "PDF Document";
				case PreviewStringId.SaveDlg_FilterTxt:
					return "Text Document";
				case PreviewStringId.SaveDlg_FilterCsv:
					return "CSV Document";
				case PreviewStringId.SaveDlg_FilterMht:
					return "MHT Document";
				case PreviewStringId.SaveDlg_FilterXls:
					return "Excel Document";
				case PreviewStringId.SaveDlg_FilterRtf:
					return "Rich Text Document";
				case PreviewStringId.SaveDlg_FilterHtm:
					return "HTML Document";
				case PreviewStringId.SaveDlg_FilterBmp:
					return "BMP Bitmap Format";
				case PreviewStringId.SaveDlg_FilterGif:
					return "GIF Graphics Interchange Format";
				case PreviewStringId.SaveDlg_FilterJpeg:
					return "JPEG File Interchange Format";
				case PreviewStringId.SaveDlg_FilterPng:
					return "PNG Portable Network Graphics Format";
				case PreviewStringId.SaveDlg_FilterTiff:
					return "TIFF Tag Image File Format";
				case PreviewStringId.SaveDlg_FilterEmf:
					return "EMF Enhanced Windows Metafile";
				case PreviewStringId.SaveDlg_FilterWmf:
					return "WMF Windows Metafile";
				case PreviewStringId.SaveDlg_Title:
					return "Save As";
				case PreviewStringId.SaveDlg_FilterNativeFormat:
					return "Native Format";
				case PreviewStringId.PageInfo_PageNumber:
					return "[Page #]";
				case PreviewStringId.PageInfo_PageNumberOfTotal:
					return "[Page # of Pages #]";
				case PreviewStringId.PageInfo_PageDate:
					return "[Date Printed]";
				case PreviewStringId.PageInfo_PageTime:
					return "[Time Printed]";
				case PreviewStringId.PageInfo_PageUserName:
					return "[User Name]";
				case PreviewStringId.EMail_From:
					return "From";
				
				case PreviewStringId.ScalePopup_GroupText:
					return "Scaling";
				case PreviewStringId.ScalePopup_AdjustTo:
					return "Adjust to:";
				case PreviewStringId.ScalePopup_NormalSize:
					return "% normal size";
				case PreviewStringId.ScalePopup_FitTo:
					return "Fit to";
				case PreviewStringId.ScalePopup_PagesWide:
					return "pages wide";
				#region export options
				case PreviewStringId.ExportOption_RtfExportMode:
					return "Export mode:";
				case PreviewStringId.ExportOption_RtfExportMode_SingleFile:
					return "Single file";
				case PreviewStringId.ExportOption_RtfExportMode_SingleFilePageByPage:
					return "Single file page-by-page";
				case PreviewStringId.ExportOption_RtfPageRange:
					return "Page range:";
				case PreviewStringId.ExportOption_RtfExportWatermarks:
					return "Export watermarks";
				case PreviewStringId.ExportOption_PdfPageRange:
					return "Page range:";
				case PreviewStringId.ExportOption_PdfCompressed:
					return "Compressed";
				case PreviewStringId.ExportOption_PdfShowPrintDialogOnOpen:
					return "Show print dialog on open";
				case PreviewStringId.ExportOption_PdfNeverEmbeddedFonts:
					return "Don't embed these fonts:";
				case PreviewStringId.ExportOption_PdfImageQuality:
					return "Images quality:";
				case PreviewStringId.ExportOption_PdfImageQuality_Lowest:
					return "Lowest";
				case PreviewStringId.ExportOption_PdfImageQuality_Low:
					return "Low";
				case PreviewStringId.ExportOption_PdfImageQuality_Medium:
					return "Medium";
				case PreviewStringId.ExportOption_PdfImageQuality_High:
					return "High";
				case PreviewStringId.ExportOption_PdfImageQuality_Highest:
					return "Highest";
				case PreviewStringId.ExportOption_PdfDocumentAuthor:
					return "Author:";
				case PreviewStringId.ExportOption_PdfDocumentApplication:
					return "Application:";
				case PreviewStringId.ExportOption_PdfDocumentTitle:
					return "Title:";
				case PreviewStringId.ExportOption_PdfDocumentSubject:
					return "Subject:";
				case PreviewStringId.ExportOption_PdfDocumentKeywords:
					return "Keywords:";
				case PreviewStringId.ExportOption_HtmlExportMode:
					return "Export mode:";
				case PreviewStringId.ExportOption_HtmlExportMode_SingleFile:
					return "Single file";
				case PreviewStringId.ExportOption_HtmlExportMode_SingleFilePageByPage:
					return "Single file page-by-page";
				case PreviewStringId.ExportOption_HtmlExportMode_DifferentFiles:
					return "Different files";
				case PreviewStringId.ExportOption_HtmlCharacterSet:
					return "Character set:";
				case PreviewStringId.ExportOption_HtmlTitle:
					return "Title:";
				case PreviewStringId.ExportOption_HtmlRemoveSecondarySymbols:
					return "Remove carriage returns";
				case PreviewStringId.ExportOption_HtmlPageRange:
					return "Page range:";
				case PreviewStringId.ExportOption_HtmlPageBorderWidth:
					return "Page border width:";
				case PreviewStringId.ExportOption_HtmlPageBorderColor:
					return "Page border color:";
				case PreviewStringId.ExportOption_TextSeparator:
					return "Text separator:";
				case PreviewStringId.ExportOption_TextSeparator_TabAlias:
					return "TAB";
				case PreviewStringId.ExportOption_TextEncoding:
					return "Encoding:";
				case PreviewStringId.ExportOption_TextQuoteStringsWithSeparators:
					return "Quote strings with separators";
				case PreviewStringId.ExportOption_XlsShowGridLines:
					return "Show grid lines";
				case PreviewStringId.ExportOption_XlsUseNativeFormat:
					return "Export values using their format";
				case PreviewStringId.ExportOption_XlsSheetName:
					return "Sheet name:";
				case PreviewStringId.ExportOption_ImageExportMode:
					return "Export mode:";
				case PreviewStringId.ExportOption_ImageExportMode_SingleFile:
					return "Single file";
				case PreviewStringId.ExportOption_ImageExportMode_SingleFilePageByPage:
					return "Single file page-by-page";
				case PreviewStringId.ExportOption_ImageExportMode_DifferentFiles:
					return "Different files";
				case PreviewStringId.ExportOption_ImagePageRange:
					return "Page range:";
				case PreviewStringId.ExportOption_ImagePageBorderWidth:
					return "Page border width:";
				case PreviewStringId.ExportOption_ImagePageBorderColor:
					return "Page border color:";
				case PreviewStringId.ExportOption_ImageFormat:
					return "Image format:";
				case PreviewStringId.ExportOption_ImageResolution:
					return "Resolution (dpi):";
				case PreviewStringId.ExportOption_NativeFormatCompressed:
					return "Compressed";
				#endregion
				case PreviewStringId.FolderBrowseDlg_ExportDirectory:
					return "Select a folder to save the exported document to:";
				case PreviewStringId.ExportOptionsForm_CaptionPdf:
					return "PDF Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionXls:
					return "XLS Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionTxt:
					return "Text Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionCsv:
					return "CSV Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionImage:
					return "Image Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionHtml:
					return "HTML Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionMht:
					return "MHT Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionRtf:
					return "RTF Export Options";
				case PreviewStringId.ExportOptionsForm_CaptionNativeOptions:
					return "Native Format Options";
				#region ribbon
				case PreviewStringId.RibbonPreview_PageText:
					return "Print Preview";
				case PreviewStringId.RibbonPreview_PageGroup_Print:
					return "Print";
				case PreviewStringId.RibbonPreview_PageGroup_PageSetup:
					return "Page Setup";
				case PreviewStringId.RibbonPreview_PageGroup_Navigation:
					return "Navigation";
				case PreviewStringId.RibbonPreview_PageGroup_Zoom:
					return "Zoom";
				case PreviewStringId.RibbonPreview_PageGroup_Background:
					return "Page Background";
				case PreviewStringId.RibbonPreview_PageGroup_Export:
					return "Export";
				case PreviewStringId.RibbonPreview_PageGroup_Document:
					return "Document";
				case PreviewStringId.RibbonPreview_DocumentMap_Caption:
					return "Bookmarks";
				case PreviewStringId.RibbonPreview_Find_Caption:
					return "Find";
				case PreviewStringId.RibbonPreview_Pointer_Caption:
					return "Pointer";
				case PreviewStringId.RibbonPreview_HandTool_Caption:
					return "Hand Tool";
				case PreviewStringId.RibbonPreview_Customize_Caption:
					return "Options";
				case PreviewStringId.RibbonPreview_Print_Caption:
					return "Print";
				case PreviewStringId.RibbonPreview_PrintDirect_Caption:
					return "Quick Print";
				case PreviewStringId.RibbonPreview_PageSetup_Caption:
					return "Custom Margins...";
				case PreviewStringId.RibbonPreview_EditPageHF_Caption:
					return "Header/Footer";
				case PreviewStringId.RibbonPreview_Magnifier_Caption:
					return "Magnifier";
				case PreviewStringId.RibbonPreview_ZoomOut_Caption:
					return "Zoom Out";
				case PreviewStringId.RibbonPreview_ZoomIn_Caption:
					return "Zoom In";
				case PreviewStringId.RibbonPreview_ZoomExact_Caption:
					return "Exact:";
				case PreviewStringId.RibbonPreview_ShowFirstPage_Caption:
					return "First Page";
				case PreviewStringId.RibbonPreview_ShowPrevPage_Caption:
					return "Previous Page";
				case PreviewStringId.RibbonPreview_ShowNextPage_Caption:
					return "Next  Page ";
				case PreviewStringId.RibbonPreview_ShowLastPage_Caption:
					return "Last  Page ";
				case PreviewStringId.RibbonPreview_MultiplePages_Caption:
					return "Many Pages";
				case PreviewStringId.RibbonPreview_FillBackground_Caption:
					return "Page Color";
				case PreviewStringId.RibbonPreview_Watermark_Caption:
					return "Watermark";
				case PreviewStringId.RibbonPreview_ExportFile_Caption:
					return "Export To";
				case PreviewStringId.RibbonPreview_SendFile_Caption:
					return "E-Mail As";
				case PreviewStringId.RibbonPreview_ClosePreview_Caption:
					return "Close Print Preview";
				case PreviewStringId.RibbonPreview_Scale_Caption:
					return "Scale";
				case PreviewStringId.RibbonPreview_PageOrientation_Caption:
					return "Orientation";
				case PreviewStringId.RibbonPreview_PaperSize_Caption:
					return "Size";
				case PreviewStringId.RibbonPreview_PageMargins_Caption:
					return "Margins";
				case PreviewStringId.RibbonPreview_Zoom_Caption:
					return "Zoom";
				case PreviewStringId.RibbonPreview_Save_Caption:
					return "Save";
				case PreviewStringId.RibbonPreview_Open_Caption:
					return "Open";
				case PreviewStringId.RibbonPreview_DocumentMap_STipTitle:
					return "Document Map";
				case PreviewStringId.RibbonPreview_Find_STipTitle:
					return "Find";
				case PreviewStringId.RibbonPreview_Pointer_STipTitle:
					return "Mouse Pointer";
				case PreviewStringId.RibbonPreview_HandTool_STipTitle:
					return "Hand Tool";
				case PreviewStringId.RibbonPreview_Customize_STipTitle:
					return "Options";
				case PreviewStringId.RibbonPreview_Print_STipTitle:
					return "Print (Ctrl+P)";
				case PreviewStringId.RibbonPreview_PrintDirect_STipTitle:
					return "Quick Print";
				case PreviewStringId.RibbonPreview_PageSetup_STipTitle:
					return "Page Setup";
				case PreviewStringId.RibbonPreview_EditPageHF_STipTitle:
					return "Header and Footer";
				case PreviewStringId.RibbonPreview_Magnifier_STipTitle:
					return "Magnifier";
				case PreviewStringId.RibbonPreview_ZoomOut_STipTitle:
					return "Zoom Out";
				case PreviewStringId.RibbonPreview_ZoomIn_STipTitle:
					return "Zoom In";
				case PreviewStringId.RibbonPreview_ShowFirstPage_STipTitle:
					return "First Page (Ctrl+Home)";
				case PreviewStringId.RibbonPreview_ShowPrevPage_STipTitle:
					return "Previous Page (PageUp)";
				case PreviewStringId.RibbonPreview_ShowNextPage_STipTitle:
					return "Next Page (PageDown)";
				case PreviewStringId.RibbonPreview_ShowLastPage_STipTitle:
					return "Last Page (Ctrl+End)";
				case PreviewStringId.RibbonPreview_MultiplePages_STipTitle:
					return "View Many Pages";
				case PreviewStringId.RibbonPreview_FillBackground_STipTitle:
					return "Background Color";
				case PreviewStringId.RibbonPreview_Watermark_STipTitle:
					return "Watermark";
				case PreviewStringId.RibbonPreview_ExportFile_STipTitle:
					return "Export To...";
				case PreviewStringId.RibbonPreview_SendFile_STipTitle:
					return "E-Mail As...";
				case PreviewStringId.RibbonPreview_ClosePreview_STipTitle:
					return "Close Print Preview";
				case PreviewStringId.RibbonPreview_Scale_STipTitle:
					return "Scale";
				case PreviewStringId.RibbonPreview_PageOrientation_STipTitle:
					return "Page Orientation";
				case PreviewStringId.RibbonPreview_PaperSize_STipTitle:
					return "Page Size";
				case PreviewStringId.RibbonPreview_PageMargins_STipTitle:
					return "Page Margins";
				case PreviewStringId.RibbonPreview_Zoom_STipTitle:
					return "Zoom";
				case PreviewStringId.RibbonPreview_PageGroup_PageSetup_STipTitle:
					return "Page Setup";
				case PreviewStringId.RibbonPreview_Save_STipTitle:
					return "Save (Ctrl + S)";
				case PreviewStringId.RibbonPreview_Open_STipTitle:
					return "Open (Ctrl + O)";
				case PreviewStringId.RibbonPreview_DocumentMap_STipContent:
					return "Open the Document Map, which allows you to navigate through a structural view of the document.";
				case PreviewStringId.RibbonPreview_Find_STipContent:
					return "Show the Find dialog to find text in the document.";
				case PreviewStringId.RibbonPreview_Pointer_STipContent:
					return "Show the mouse pointer.";
				case PreviewStringId.RibbonPreview_HandTool_STipContent:
					return "Invoke the Hand tool to manually scroll through pages.";
				case PreviewStringId.RibbonPreview_Customize_STipContent:
					return "Open the Printable Component Editor dialog, in which you can change printing options.";
				case PreviewStringId.RibbonPreview_Print_STipContent:
					return "Select a printer, number of copies and other printing options before printing.";
				case PreviewStringId.RibbonPreview_PrintDirect_STipContent:
					return "Send the document directly to the default printer without making changes.";
				case PreviewStringId.RibbonPreview_PageSetup_STipContent:
					return "Show the Page Setup dialog.";
				case PreviewStringId.RibbonPreview_EditPageHF_STipContent:
					return "Edit the header and footer of the document.";
				case PreviewStringId.RibbonPreview_Magnifier_STipContent:
					return "Invoke the Magnifier tool.\r\n\r\nClicking once on a document zooms it so that a single page becomes entirely visible, while clicking another time zooms it to 100% of the normal size.";
				case PreviewStringId.RibbonPreview_ZoomOut_STipContent:
					return "Zoom out to see more of the page at a reduced size.";
				case PreviewStringId.RibbonPreview_ZoomIn_STipContent:
					return "Zoom in to get a close-up view of the document.";
				case PreviewStringId.RibbonPreview_ShowFirstPage_STipContent:
					return "Navigate to the first page of the document.";
				case PreviewStringId.RibbonPreview_ShowPrevPage_STipContent:
					return "Navigate to the previous page of the document.";
				case PreviewStringId.RibbonPreview_ShowNextPage_STipContent:
					return "Navigate to the next page of the document.";
				case PreviewStringId.RibbonPreview_ShowLastPage_STipContent:
					return "Navigate to the last page of the document.";
				case PreviewStringId.RibbonPreview_MultiplePages_STipContent:
					return "Choose the page layout to arrange the document pages in preview.";
				case PreviewStringId.RibbonPreview_FillBackground_STipContent:
					return "Choose a color for the background of the document pages.";
				case PreviewStringId.RibbonPreview_Watermark_STipContent:
					return "Insert ghosted text or image behind the content of a page.\r\n\r\nThis is often used to indicate that a document is to be treated specially.";
				case PreviewStringId.RibbonPreview_ExportFile_STipContent:
					return "Export the current document in one of the available formats, and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_SendFile_STipContent:
					return "Export the current document in one of the available formats, and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_ClosePreview_STipContent:
					return "Close Print Preview of the document.";
				case PreviewStringId.RibbonPreview_Scale_STipContent:
					return "Stretch or shrink the printed output to a percentage of its actual size.";
				case PreviewStringId.RibbonPreview_PageOrientation_STipContent:
					return "Switch the pages between portrait and landscape layouts.";
				case PreviewStringId.RibbonPreview_PaperSize_STipContent:
					return "Choose the paper size of the document.";
				case PreviewStringId.RibbonPreview_PageMargins_STipContent:
					return "Select the margin sizes for the entire document.\r\n\r\nTo apply specific margin sizes to the document, click Custom Margins.";
				case PreviewStringId.RibbonPreview_Zoom_STipContent:
					return "Change the zoom level of the document preview.";
				case PreviewStringId.RibbonPreview_PageGroup_PageSetup_STipContent:
					return "Show the Page Setup dialog.";
				case PreviewStringId.RibbonPreview_Save_STipContent:
					return "Save the document.";
				case PreviewStringId.RibbonPreview_Open_STipContent:
					return "Open a document.";
				case PreviewStringId.RibbonPreview_ExportPdf_Caption:
					return "PDF File";
				case PreviewStringId.RibbonPreview_ExportHtm_Caption:
					return "HTML File";
				case PreviewStringId.RibbonPreview_ExportTxt_Caption:
					return "Text File";
				case PreviewStringId.RibbonPreview_ExportCsv_Caption:
					return "CSV File";
				case PreviewStringId.RibbonPreview_ExportMht_Caption:
					return "MHT File";
				case PreviewStringId.RibbonPreview_ExportXls_Caption:
					return "Excel File";
				case PreviewStringId.RibbonPreview_ExportRtf_Caption:
					return "RTF File";
				case PreviewStringId.RibbonPreview_ExportGraphic_Caption:
					return "Image File";
				case PreviewStringId.RibbonPreview_SendPdf_Caption:
					return "PDF File";
				case PreviewStringId.RibbonPreview_SendTxt_Caption:
					return "Text File";
				case PreviewStringId.RibbonPreview_SendCsv_Caption:
					return "CSV File";
				case PreviewStringId.RibbonPreview_SendMht_Caption:
					return "MHT File";
				case PreviewStringId.RibbonPreview_SendXls_Caption:
					return "Excel File";
				case PreviewStringId.RibbonPreview_SendRtf_Caption:
					return "RTF File";
				case PreviewStringId.RibbonPreview_SendGraphic_Caption:
					return "Image File";
				case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationPortrait_Caption:
					return "Portrait";
				case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationLandscape_Caption:
					return "Landscape";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNormal_Caption:
					return "Normal";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNarrow_Caption:
					return "Narrow";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsModerate_Caption:
					return "Moderate";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsWide_Caption:
					return "Wide";
				case PreviewStringId.RibbonPreview_ExportPdf_Description:
					return "Adobe Portable Document Format";
				case PreviewStringId.RibbonPreview_ExportHtm_Description:
					return "Web Page";
				case PreviewStringId.RibbonPreview_ExportTxt_Description:
					return "Plain Text";
				case PreviewStringId.RibbonPreview_ExportCsv_Description:
					return "Comma-Separated Values Text";
				case PreviewStringId.RibbonPreview_ExportMht_Description:
					return "Single File Web Page";
				case PreviewStringId.RibbonPreview_ExportXls_Description:
					return "Microsoft Excel Workbook";
				case PreviewStringId.RibbonPreview_ExportRtf_Description:
					return "Rich Text Format";
				case PreviewStringId.RibbonPreview_ExportGraphic_Description:
					return "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";
				case PreviewStringId.RibbonPreview_SendPdf_Description:
					return "Adobe Portable Document Format";
				case PreviewStringId.RibbonPreview_SendTxt_Description:
					return "Plain Text";
				case PreviewStringId.RibbonPreview_SendCsv_Description:
					return "Comma-Separated Values Text";
				case PreviewStringId.RibbonPreview_SendMht_Description:
					return "Single File Web Page";
				case PreviewStringId.RibbonPreview_SendXls_Description:
					return "Microsoft Excel Workbook";
				case PreviewStringId.RibbonPreview_SendRtf_Description:
					return "Rich Text Format";
				case PreviewStringId.RibbonPreview_SendGraphic_Description:
					return "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";
				case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationPortrait_Description:
					return " ";
				case PreviewStringId.RibbonPreview_GalleryItem_PageOrientationLandscape_Description:
					return " ";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNormal_Description:
					return "Normal";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsNarrow_Description:
					return "Narrow";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsModerate_Description:
					return "Moderate";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMarginsWide_Description:
					return "Wide";
				case PreviewStringId.RibbonPreview_ExportPdf_STipTitle:
					return "Export to PDF";
				case PreviewStringId.RibbonPreview_ExportHtm_STipTitle:
					return "Export to HTML";
				case PreviewStringId.RibbonPreview_ExportTxt_STipTitle:
					return "Export to Text";
				case PreviewStringId.RibbonPreview_ExportCsv_STipTitle:
					return "Export to CSV";
				case PreviewStringId.RibbonPreview_ExportMht_STipTitle:
					return "Export to MHT";
				case PreviewStringId.RibbonPreview_ExportXls_STipTitle:
					return "Export to XLS";
				case PreviewStringId.RibbonPreview_ExportRtf_STipTitle:
					return "Export to RTF";
				case PreviewStringId.RibbonPreview_ExportGraphic_STipTitle:
					return "Export to Image";
				case PreviewStringId.RibbonPreview_SendPdf_STipTitle:
					return "E-Mail As PDF";
				case PreviewStringId.RibbonPreview_SendTxt_STipTitle:
					return "E-Mail As Text";
				case PreviewStringId.RibbonPreview_SendCsv_STipTitle:
					return "E-Mail As CSV";
				case PreviewStringId.RibbonPreview_SendMht_STipTitle:
					return "E-Mail As MHT";
				case PreviewStringId.RibbonPreview_SendXls_STipTitle:
					return "E-Mail As XLS";
				case PreviewStringId.RibbonPreview_SendRtf_STipTitle:
					return "E-Mail As RTF";
				case PreviewStringId.RibbonPreview_SendGraphic_STipTitle:
					return "E-Mail As Image";
				case PreviewStringId.RibbonPreview_ExportPdf_STipContent:
					return "Export the document to PDF and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportHtm_STipContent:
					return "Export the document to HTML and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportTxt_STipContent:
					return "Export the document to Text and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportCsv_STipContent:
					return "Export the document to CSV and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportMht_STipContent:
					return "Export the document to MHT and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportXls_STipContent:
					return "Export the document to XLS and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportRtf_STipContent:
					return "Export the document to RTF and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_ExportGraphic_STipContent:
					return "Export the document to Image and save it to the file on a disk.";
				case PreviewStringId.RibbonPreview_SendPdf_STipContent:
					return "Export the document to PDF and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_SendTxt_STipContent:
					return "Export the document to Text and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_SendCsv_STipContent:
					return "Export the document to CSV and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_SendMht_STipContent:
					return "Export the document to MHT and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_SendXls_STipContent:
					return "Export the document to XLS and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_SendRtf_STipContent:
					return "Export the document to RTF and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_SendGraphic_STipContent:
					return "Export the document to Image and attach it to the e-mail.";
				case PreviewStringId.RibbonPreview_GalleryItem_PageMargins_Description:
					return "Top:\t\t{0}\t\tBottom:\t\t{1}\r\nLeft:\t\t {2}\t\tRight:\t\t   {3}";
				case PreviewStringId.RibbonPreview_GalleryItem_PaperSize_Description:
					return "{0} x {1}";
				#endregion
				case PreviewStringId.OpenFileDialog_Filter:
					return "Preview Document Files (*{0})|*{0}|All Files (*.*)|*.*";
				case PreviewStringId.OpenFileDialog_Title:
					return "Open";
				default:
                    ret = base.GetLocalizedString(id);
					break;
			}
			return ret;
		}
		
    }

    public class NVTreeListLocalizer : TreeListLocalizer
    {

        public override string GetLocalizedString(TreeListStringId id)
        {
            // lam sau
            switch (id)
            {
                case TreeListStringId.MenuColumnBestFit: return "Điều chỉnh kích thước cột";
                case TreeListStringId.MenuColumnBestFitAllColumns: return "Điều chỉnh kích thước tất cả cột";
                case TreeListStringId.MenuColumnSortAscending: return "Sắp xếp tăng";
                case TreeListStringId.MenuColumnSortDescending: return "Sắp xếp giảm";
                case TreeListStringId.MenuColumnColumnCustomization: return "Điều chỉnh ẩn hiện cột";
                case TreeListStringId.ColumnCustomizationText: return "Điều chỉnh ẩn hiện cột";
            }
            return base.GetLocalizedString(id);
        }
    }

    public class NVLayoutLocalizer : LayoutLocalizer
    {
        public override string GetLocalizedString(LayoutStringId id)
        {
            switch (id)
            {
                case LayoutStringId.CustomizationParentName: return "Điều chỉnh vị trí";
                case LayoutStringId.DefaultItemText: return "Item ";
                case LayoutStringId.DefaultActionText: return "DefaultAction";
                case LayoutStringId.DefaultEmptyText: return "none";
                case LayoutStringId.LayoutItemDescription: return "Layout control item element";
                case LayoutStringId.LayoutGroupDescription: return "Layout control group element";
                case LayoutStringId.TabbedGroupDescription: return "Layout control tabbedGroup element";
                case LayoutStringId.LayoutControlDescription: return "Layout control";
                case LayoutStringId.CustomizationFormTitle: return "Điều chỉnh vị trí";
                case LayoutStringId.TreeViewPageTitle: return "Cây hiển thị";
                case LayoutStringId.HiddenItemsPageTitle: return "Item được ẩn";
                case LayoutStringId.RenameSelected: return "Sửa tên";
                case LayoutStringId.HideItemMenutext: return "Ẩn item";
                case LayoutStringId.LockItemSizeMenuText: return "Cố định kích thước";
                case LayoutStringId.UnLockItemSizeMenuText: return "UnLock Item Size";
                case LayoutStringId.GroupItemsMenuText: return "Group";
                case LayoutStringId.UnGroupItemsMenuText: return "Ungroup";
                case LayoutStringId.CreateTabbedGroupMenuText: return "Tạo Tab Control";
                case LayoutStringId.AddTabMenuText: return "Thêm Tab";
                case LayoutStringId.UnGroupTabbedGroupMenuText: return "Xóa Tab Control";
                case LayoutStringId.TreeViewRootNodeName: return "Gốc";
                case LayoutStringId.ShowCustomizationFormMenuText: return "Điều chỉnh vị tri";
                case LayoutStringId.HideCustomizationFormMenuText: return "Hide Customization Form";
                case LayoutStringId.EmptySpaceItemDefaultText: return "Item trống";
                case LayoutStringId.SplitterItemDefaultText: return "Thanh kéo";
                case LayoutStringId.ControlGroupDefaultText: return "Group ";
                case LayoutStringId.EmptyRootGroupText: return "Drop controls here";
                case LayoutStringId.EmptyTabbedGroupText: return "Drag drop groups into the caption area";
                case LayoutStringId.ResetLayoutMenuText: return "Reset Layout";
                case LayoutStringId.RenameMenuText: return "Sửa tên";
                case LayoutStringId.TextPositionMenuText: return "Vị trí tiêu đề";
                case LayoutStringId.TextPositionLeftMenuText: return "Trái";
                case LayoutStringId.TextPositionRightMenuText: return "Phải";
                case LayoutStringId.TextPositionTopMenuText: return "Trên";
                case LayoutStringId.TextPositionBottomMenuText: return "Dưới";
                case LayoutStringId.ShowTextMenuItem: return "Hiện tiêu đề";
                case LayoutStringId.HideTextMenuItem: return "Ẩn tiêu đề";
                case LayoutStringId.LockSizeMenuItem: return "Cố định kích thước";
                case LayoutStringId.LockWidthMenuItem: return "Cố định chiều ngang";
                case LayoutStringId.LockHeightMenuItem: return "Cố định chiều dọc";
                case LayoutStringId.FreeSizingMenuItem: return "Kích thước tự do";
                case LayoutStringId.CreateEmptySpaceItem: return "Tạo item trống";
                case LayoutStringId.UndoButtonHintText: return "Undo last action";
                case LayoutStringId.RedoButtonHintText: return "Redo last action";
                case LayoutStringId.SaveButtonHintText: return "Lưu layout thành file XML";
                case LayoutStringId.LoadButtonHintText: return "Nạp layout từ file XML";
                case LayoutStringId.UndoHintCaption: return "Undo(Ctrl+Z)";
                case LayoutStringId.RedoHintCaption: return "Redo(Ctrl+Y)";
                case LayoutStringId.LoadHintCaption: return "Nạp layout(Ctrl+O)";
                case LayoutStringId.SaveHintCaption: return "Lưu layout(Ctrl+S)";
                default:
                    break;
            }
            return base.GetLocalizedString(id);
        }
    }

}
