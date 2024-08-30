$(document).ready(function() {
    $('#nav-signup').click(function () {
        $('#nav-signup').fadeOut('fast',function () {
            $('#nav-login').fadeIn();
        });

       $('#loginform').fadeOut('fast',function () {
           $('#signupform').fadeIn();
       });
       $('#signedupmsg').hide();
      }
   );
    $('#nav-login').click(function () {
        $('#nav-login').fadeOut('fast',function () {
            $('#nav-signup').fadeIn();
        });
        $('#signupform').fadeOut('fast',function () {
                $('#loginform').fadeIn();
        });
        $('#signupform').trigger('reset');
        $('#pass-error').hide();
        $('#email-error').hide();

        }
    );


    if ($('#pass-error').css('display')!='none'  )
    {
        $('#nav-signup').hide();
        $('#nav-login').show();

        $('#loginform').hide();
        $('#signupform').show();
    }
    $('#loginform').on('submit',
        function () {
            var loginEmail = $("#loginEmail").val();
            var loginPassword = $("#loginPassword").val();
            var logindata = { login_Email: loginEmail, login_Password: loginPassword }
            $.ajax(
                {
                    url: '/User/ValidateUser',
                    type: 'Post',
                    datatype: 'json',
                    data: logindata,
                    success: function (resp) {
                        console.log(resp.Error);
                        $("#loginError").text(resp.Error);
                    },
                    error: function(resp) {
                        $("#loginError").text(resp.text);
                    }
                }
            );
            return false;
        });

    

    $('#signupform').on('submit', function ()
        {
        var username = $('#username').val();
        var signupEmail = $('#signupEmail').val()
        var signupPassword = $('#signupPassword').val()
        var confirmPassword = $('#confirmPassword').val()
        debugger;
        if (signupPassword == confirmPassword) {
            var signupdata = { signup_Email: signupEmail, user_Name: username, signup_Password: signupPassword };
            $.ajax(
                {
                    url: '/User/SignUpUser',
                    type: 'Post',
                    datatype: 'json',
                    data: signupdata,
                    success: function (resp) {
                        debugger;
                        if (resp.Error == "Success") {
                            $("#signedupmsg").text("You have successfully Signed Up! Let's Login!");
                            $("#signedupmsg").show();
                            $("#email-error").empty();
                            $('#signupform').trigger('reset');
                            $('#nav-login').fadeOut('fast', function () {
                                $('#nav-signup').fadeIn();
                            });
                            $('#signupform').fadeOut('fast', function () {
                                $('#loginform').fadeIn();
                            });
                            $('#pass-error').hide();
                            $('#email-error').hide();

                        } else {
                            $("#email-error").text(resp.Error);
                        }


                    },
                    error: function (resp) {
                        $("#email-error").text("Sign Up Failed");
                    }
                }
            );
            return false;
        }
        else{
            $('#pass-error').show();
            return false;
        }
    }

    );
  }
);
