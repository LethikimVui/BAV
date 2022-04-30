$(document).ready(function () {

    $('body').off('click', '#btn-search').on('click', '#btn-search', Load)
    $('body').off('click', '#btn-reset').on('click', '#btn-reset', Reset)
    $('body').off('click', '#btn-export').on('click', '#btn-export', Export);


    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');


    var homeconfig = {
        pageSize: 15,
        pageIndex: 1
    }

    var LogTable =
    {
        loadData: function (changePageSize) {
            var totalRecord = 0;
            //  $("#loading").show();

            var model = new Object();
            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.Model = $('#txt-assembly-search').val() ? $('#txt-assembly-search').val() : null;
            model.DateFrom = $('#txt-from-search').val() ? $('#txt-from-search').val() : null;
            model.DateTo = $('#txt-to-search').val() ? $('#txt-to-search').val() : null;

            debugger

            $.ajax({
                type: 'post',
                url: '/log/Log_count',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    totalRecord = parseInt(data.result);
                    $.ajax({
                        type: 'post',
                        url: '/log/Log_get',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            $("#tbl-data").html(data);
                            LogTable.paging(totalRecord, function () { }, changePageSize);
                        }
                    });

                }
            });
        },
        paging: function (totalRow, callback, changePageSize) {

            var totalPage = 0;
            if (totalRow < homeconfig.pageSize) {
                totalPage = 1
            }
            else {
                totalPage = Math.ceil(totalRow / homeconfig.pageSize);
            }

            if ($('#pagination a').length === 0 || changePageSize === true) {
                $('#pagination').empty();
                $('#pagination').removeData("twbs-pagination");
                $('#pagination').unbind("page");
            }
            $('#pagination').twbsPagination({
                totalPages: totalPage,
                first: "<<",
                next: ">",
                last: ">>",
                prev: "<",
                visiblePages: 15,
                onPageClick: function (event, page) {
                    homeconfig.pageIndex = page;
                    LogTable.loadData();
                }
            });
            // $("#loading").hide();
        },
    }
    function Load() {
        LogTable.loadData(true);
    }


    function Reset() {
        window.location.reload();
    }

    const EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
    const EXCEL_EXTENSION = '.xlsx';

    function Export() {
        var data = [];
        var model = new Object();
        model.Model = $('#txt-assembly-search').val() ? $('#txt-assembly-search').val() : null;
        model.DateFrom = $('#txt-from-search').val() ? $('#txt-from-search').val() : null;
        model.DateTo = $('#txt-to-search').val() ? $('#txt-to-search').val() : null;       
        
        $.ajax({
            async: false,
            type: 'post',
            url: '/log/Log_getall',
            data: JSON.stringify(model),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                data = response.result;
                const worksheet = XLSX.utils.json_to_sheet(data);
                const workbook = {
                    Sheets: {
                        'data': worksheet
                    },
                    SheetNames: ['data']
                };
                const excelBuffer = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
                SaveAsExcel(excelBuffer, 'Log ');
            }
        });
    }


    function SaveAsExcel(buffer, filename) {
        var dateTime = new Date(Date.now());
        var strDateTime = dateTime.getFullYear() + '' + (dateTime.getMonth() + 1) + dateTime.getDate() + dateTime.getHours() + dateTime.getMinutes() + dateTime.getMilliseconds();
        const data = new Blob([buffer], { type: EXCEL_TYPE });
        debugger
        saveAs(data, filename + strDateTime + EXCEL_EXTENSION);

    }
})