function initDataTableCompetences() {

    $('#dtCvCompetenceList').DataTable({
        ajax: ajaxPath,
        processing: false,
        serverSide: true,
        lengthChange: false,
        searching: true,
        ordering: true,
        columns: [
           {
               data: "Code",
               ordering: true,
           },
            {
                data: "Name",
                ordering: true,
            },
           {
               data: "Description",
               ordering: true,
           },
           {
               data: "Action",
               ordering: false,
               render: function (obj, type, f) {
                   if (f.Action.length > 0) {
                       return "<a href='" + editPath +"/" + f.Action + "'>Edit...<a>";
                   } else {
                       return "";
                   }
               }
           },
        ],
        language: {
            processing: "Učitavanje podataka...",
            search: "Pretraži:",
            loadingRecords: "Ućitavanje...",
            zeroRecords: "Ne postoji ni jedan zapis",
            emptyTable: "Ne postoji ni jedan zapis",
            info: "Od _START_ do  _END_ (od ukupno _TOTAL_)",
            infoEmpty: "Nema potvrda za prikazati",
            paginate: {
                first: "Prva",
                previous: "Natrag",
                next: "Naprijed",
                last: "Zadnja"
            }
        }
    });

}

$(function () {
    if (viewname == "CvCompetenceListAjax") {
        $(document).ready(function () {
            initDataTableCompetences();
        });
    }
});