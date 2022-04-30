$(document).ready(function () {

    $('body').off('click', '#btn-search').on('click', '#btn-search', Load)
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add)
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete)
    $('body').off('click', '#btn-reset').on('click', '#btn-reset', Reset)


    user = document.getElementById('userinfo').getAttribute('data-user');
    name = document.getElementById('userinfo').getAttribute('data-display-name');
    email = document.getElementById('userinfo').getAttribute('data-email');


    var homeconfig = {
        pageSize: 15,
        pageIndex: 1
    }

    var ConfigurationTable =
    {
        loadData: function (changePageSize) {
            var totalRecord = 0;
            //  $("#loading").show();

            assy = $('#txt-assembly-search').val() ? $('#txt-assembly-search').val() : null;
            accessory = $('#txt-accessory-search').val() ? $('#txt-accessory-search').val() : null;
            revision = $('#txt-revision-search').val() ? $('#txt-revision-search').val() : null;

            var model = new Object();
            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.Model = assy;
            model.Revision = revision;
            model.Accessory = accessory;
            debugger

            $.ajax({
                type: 'post',
                url: '/bav/Configuration_count',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    totalRecord = parseInt(data.result);
                    $.ajax({
                        type: 'post',
                        url: '/bav/Configuration_get',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            $("#tbl-data").html(data);
                            ConfigurationTable.paging(totalRecord, function () { }, changePageSize);
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
                    ConfigurationTable.loadData();
                }
            });
            // $("#loading").hide();
        },
    }
    function Load() {
        ConfigurationTable.loadData(true);
    }

    //function Load() {
    //    assy = $('#txt-assembly-search').val() ? $('#txt-assembly-search').val() : null;
    //    accessory = $('#txt-accessory-search').val() ? $('#txt-accessory-search').val() : null;
    //    revision = $('#txt-revision-search').val() ? $('#txt-revision-search').val() : null;

    //    var model = new Object();
    //    model.Model = assy;
    //    model.Revision = revision;
    //    model.Accessory = accessory;
    //    debugger
    //    $.ajax({
    //        type: 'post',
    //        url: '/bav/Configuration_getall',
    //        data: JSON.stringify(model),
    //        contentType: "application/json; charset=utf-8",
    //        success: function (response) {
    //            debugger
    //            //$('#tbl-data').html(response);
    //            $("#tbl-data").html(response);
    //        }
    //    });
    //}


    function Add() {
        assy = $('#txt-model').val().trim();
        family = $('#txt-family').val().trim();
        revision = $('#txt-revision').val().trim();
        accessory = $('#txt-accessory').val().trim();
        debugger
        if (assy && family && accessory && revision) {
            var model = new Object();
            model.Model = assy;
            model.Family = family;
            model.Revision = revision;
            model.Accessory = accessory;
            model.Description = $('#txt-description').val().trim();
            model.CreatedBy = user;
            model.CreatedName = name;
            model.CreatedEmail = email;
            $.ajax({
                type: 'post',
                url: '/BAV/Configuration_add',
                data: JSON.stringify(model),
                dataType: 'json',
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    bootbox.alert(response.results.message, function () { Load() })
                }
            });
        }
        else {
            bootbox, alert('Please input Model / Family / Revision / Accessory')
        }
    }

    function Delete() {
        var model = new Object();
        model.Id = parseInt($(this).attr('data-id'));
        model.CreatedBy = user;
        model.CreatedName = name;
        model.CreatedEmail = email;
        $.ajax({
            type: 'post',
            url: '/BAV/Configuration_delete',
            data: JSON.stringify(model),
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            success: function (response) {
                bootbox.alert(response.results.message, function () { Load() })
            }
        });
    }
    function Reset() {
        window.location.reload();
    }
})