//window.initialiseStatExtractor = function () {
//    console.log('JavaScript functions loading...');

//    setTimeout(function () {

//        // check if browser supports drag and drop, then set drop area
//        if (isAdvancedUpload) {
//            var $form = $('.box');
//            console.log('Features: drag and drop enabled.');
//            $form.addClass('has-advanced-upload');

//            var $formInput = $('.box__input');
//            $formInput.fadeIn();

//            var droppedFiles = false;

//            $form
//                .on('drag dragstart dragend dragover dragenter dragleave drop', function (e) {
//                    e.preventDefault();
//                    e.stopPropagation();
//                })
//                .on('dragover dragenter', function () {
//                    $form.addClass('is-dragover');
//                })
//                .on('dragleave dragend drop', function () {
//                    $form.removeClass('is-dragover');
//                })
//                .on('drop', function (e) {
//                    droppedFiles = e.originalEvent.dataTransfer.files;
//                    e.preventDefault();

//                    let file = droppedFiles[0];

//                    let reader = new FileReader()
//                    reader.readAsDataURL(file)

//                    reader.onloadend = async function () {
//                        // TODO feed this into C# method
//                        const [,base64text] = await reader.result.split(',');
//                        const decodedOnce = await atob(base64text);
//                        //const substring = await decodedOnce.substr(11);
//                        var playerData = await StatExtractor.DecodeToJSON(decodedOnce);
//                        window.StatExtractor.playerData = JSON.parse(playerData);
//                    }
//                });
//        }

//        window.StatExtractor = {
//            DecodeToJSON: function (savefile) {
//                return DotNet.invokeMethodAsync('NGUSaveAnalyser', 'DecodeToJSON', savefile)
//            },
//            handleFiles: function (files) {
//                console.log(files);
//            },
//            logger: function (string) {
//                console.log(string);
//            }
//        };

//        console.log('JavaScript functions ready!');
//    }, 1000);

//};

//var isAdvancedUpload = function () {
//    var div = document.createElement('div');
//    return (('draggable' in div) || ('ondragstart' in div && 'ondrop' in div)) && 'FormData' in window && 'FileReader' in window;
//}();
