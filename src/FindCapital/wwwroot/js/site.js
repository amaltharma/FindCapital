// Write your Javascript code.
$(document).ready(function () {
    $("#stateName").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Home/GetStateAutoComplete",
                type: "POST",
                dataType: "json",
                data: { state: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {label: item.stateName, stateNameAbbrivation: item.stateNameAbbrivation, stateCapitol: item.stateCapitol };
                    }))

                }
            })
        },
        minLength: 3,
        select: function(event, ui){                
                $("#stateNameAbbrivation").val(ui.item.stateNameAbbrivation);
                $("#stateCapitol").val(ui.item.stateCapitol);            
        }        
    }).autocomplete("widget").addClass("fixed-height");
})