$(document).ready(function(){
    var pageLoad = function (folderid) {
		$.ajax(
				{
					url: '/User/GetFolders',
					type: 'Post',
					dataType: 'json',
					data: {pf_id:folderid},
					success: displayFolders
				}
			);
	};
	var colorindex=	Math.floor(Math.random() * 4);     // returns a random integer from 0 to 3
	var currentpfid = -1;
    pageLoad(-1);


	function displayFolders(data)
    {
        $('#foldersCards').empty();
		var colors=["bg-primary","bg-danger","bg-inverse","bg-success"]
		for(var folders of data) {
			var cards=  '<div class="col-sm-3">'+
						'<div fid='+folders["folderID"]+' class="card mycards text-center text-white borderDiv '+colors[colorindex]+' mb-3">'+
						'  <div class="card-body">'+
						'    <h4 class="card-title card-font">'+folders["folderName"]+'</h4><hr>'+
						'    <img src="/Content/images/card-folder.png" class="img-fluid wid"'+
						'  </div>'+
						'</div>'+
						'</div>';
						colorindex=(colorindex+1)%4;
			$('#foldersCards').append(cards);
		}

	}

	$("#createNewFolder").on("click",function () {

		var name = $("#newfoldername").val();
		if (name!='') {
            $.ajax(
                {
                    url: '/User/AddFolder',
					type: 'Post',
					dataType: 'json',
                    data: { folder_name: name, pf_id: currentpfid},
                    success: displayFolders,
				}
			);
		}
		else {
			alert("Folder Name Cannot Be Empty");
		}
    });


	$("body").on('click','.card',function () {
		$('.card').not(this).removeClass('selectedDiv');
		$(this).toggleClass('selectedDiv');
	});

	$("body").on('dblclick','.card',function () {
		currentpfid = $(this).attr('fid');
		pageLoad(currentpfid);
		var folname = $(this).text();
		$('#modalPfolder').text(folname);
		$('.folder-structure').append("<span class='folderlinks'>&ensp;<a  fid='"+currentpfid+"'>/"+folname+"</a> </span>");
	});

	$("body").on('click','.folderlinks',function () {
		currentpfid=$(this).find('a').attr('fid');
		$(this).nextAll().remove();
		pageLoad(currentpfid);
	});

  }
);
