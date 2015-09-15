//Custom Scripts for the Form Application

//init
$(function () {
    //Default Hiding of Description
    $('.top-border').hide();
    $('.panel-body').hide();
    $('.information-heading').hide();
    $('.toggle-border').hide();
    $('.panel-dependant').hide();

    //initializes datetimepicker addon
    $('.date').datetimepicker();

    //initializes default dropdown text
    $('#Term > option').each(function () {
        if (this.text == "Select Term") {
            $(this).attr('selected', "true");
            $(this).attr('style', "display:none;")
        }
    });
});

//toggles tooltip changes
$('.panel-toggle').hover(function () {
    if ($(this).siblings('.top-border').is(':visible')) {
        $(this).attr('title', "Click 'Minimize' To Hide Details");
    }
    else {
        $(this).attr('title', "Click 'Show' to View More Details");
    }
});

//Allow Multiple Logic
$('#AllowMultipleAttempts').on('click', function () {
    if ($(this).is(':checked')) {
        $(this).parent().siblings('.panel-dependant').show('slow');
    }
    if (!$(this).is(':checked')) {
        $(this).parent().siblings('.panel-dependant').hide('slow');
    }
});

//Show one question logic
$('#ShowOneQuestionAtTime').on('click', function () {
    if ($(this).is(':checked')) {
        $(this).parent().siblings('.panel-dependant').show('slow');
    }
    if (!$(this).is(':checked')) {
        $(this).parent().siblings('.panel-dependant').hide('slow');
    }
});

//handles minimizing of panels
$('.minimize').on('click', function (e) {
    $(this).parent().siblings().hide('slow');
});

//handles showing of content, with custom
//content handlers
$('.show1').on('click', function () {
    $(this).parent().siblings().show('slow');
    //$(this).parent().siblings('.top-border').show('slow');
});

//show content handler for AllowMultiple
$('.show2').on('click', function () {
    if ($('#AllowMultipleAttempts').is(':checked')) {
        $(this).parent().siblings().show('slow');
    }
    else {
        $(this).parent().siblings('.showme').show('slow');
    }
});

//show content handler for showonequestion
$('.show3').on('click', function () {
    if ($('#ShowOneQuestionAtTime').is(':checked')) {
        $(this).parent().siblings().show('slow');
    }
    else {
        $(this).parent().siblings('.showme').show('slow');
    }
});

//validation
$('#submit').on('click', function () {

    //show quiztype element if not checked for validation
    if (!$('input:radio[name="QuizType"]').is(":checked")) {
        $('#panel').siblings().show('slow');
        $('#panel').parent().attr('style', "border-color:#b94a48;");
    }
    //hide and revert border color
    else {
        $('#panel').siblings().hide('slow');
    }


});

//revert color to match MVC form validation fixes for quiztype
$('input:radio[name="QuizType"]').on('change', function () {
    if ($(this).is(':checked')) {
        $('#panel').parent().attr('style', "border-color:black;");
    }
});