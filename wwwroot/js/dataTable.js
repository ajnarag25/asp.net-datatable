$(document).ready(function () {
    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        $.fn.dataTable.tables({ visible: true, api: true }).columns.adjust();
    });

    $('table.table').DataTable({
        ajax: '../textfile/data.txt',
        scrollY: 500,
        scrollCollapse: true,
        paging: false,
    });

});