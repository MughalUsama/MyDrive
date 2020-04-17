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
        $('#pass-error').hide();
        $('#email-error').hide();

        }
    );


    if ($('#pass-error').css('display')!='none' || $('#email-error').length>0 )
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
            debugger 
            $.ajax(
                {
                    url: '/User/ValidateUser',
                    type: 'Post',
                    datatype: 'text',
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

    

    $('#signupform').on('submit',function()
    {
      var spass=$('#signupPassword').val();
      var sconpass=$('#confirmPassword').val();

      if (spass==sconpass) {
        return true;
      }
      else{
        $('#pass-error').show();
        return false;
      }
    }

    );
  }
);
