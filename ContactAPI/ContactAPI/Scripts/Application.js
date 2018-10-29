var apiurl = "http://localhost:49432/api/Contacts/";
$.getJSON(apiurl).done(function (data) {
    var table = '<table>';
    $.each(data, function (key, item) {
        table += '<tr><td>' + item.firstName + '</td><tb>' + item.lastName + '</td><tb>' + item.gender + '</td><tb>' + item.phoneNumber + '</td><tb>' + item.emailAddress + '</td><tb>' + item.city + '</td><tb>' +
            '</td></tr>';
    });
    table += '</table>'; 
});