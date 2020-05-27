<html lang="en"><head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Image Survey HTML Form by templatemo</title>

    <!-- load CSS -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600">
    <!-- Google web font "Open Sans" -->
    <link rel="stylesheet" href="css/materialize.min.css">
    <!-- https://materializecss.com -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- https://getbootstrap.com/ -->
    <link rel="stylesheet" href="css/all.min.css">
    <!-- https://fontawesome.com/ -->
    <link rel="stylesheet" href="css/templatemo-style.css">
    <!-- Template Mo style -->
    
</head>

<body class="">
    <div class="container">
        <div class="row">
            <div class="col-sm-12 col-md-7">
                <i class="far fa-comments fa-5x tm-site-icon"></i>
                <h1 class="tm-site-name">Image Survey</h1>
            </div>
            <div class="col-sm-12 col-md-5 mt-md-0 mt-5">
                <div class="tm-site-header-right-col">
                    <a href="#" class="btn btn-primary">Contact Us</a>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <div class="tm-parallax" style="background-position: center 859px;"></div>
            </div>
        </div>
        <div class="row">
            <div class="tm-intro">
                <div class="col-sm-12 col-md-8 mb-md-0 mb-4 tm-intro-left">
                    <p class="mb-0"> site. Thank you.</p>
                </div>
                <div class="col-sm-12 col-md-4">
                    <em>
                        
                    </em>
                </div>
            </div>
            <div class="col-12">
                <hr>
            </div>
        </div>

        <form action="" method="post">
            <div class="row">
                <div class="col-12">
                    <h2 class="tm-question-header">Question 1</h2>
                    <p>Fusce feugiat, est dignissim feugiat dapibus, arcu lacus varius dolor, vel auctor odio lectus
                        sed diam. Ut gravida tristique lacus, sed molestie tellus faucibus non.</p>
                    <div class="tm-q-choice-container">
                        <label class="tm-q-choice">
                            <div class="mb-3">
                                <input class="tm-radio-group-1 with-gap" name="q1" type="radio" value="q1_a1">
                                <span>A. Pellentesque quis matus</span>
                            </div>
                            <img src="img/img-3x2-1.jpg" alt="Image">
                        </label>
                        <label class="tm-q-choice">
                            <div class="mb-3">
                                <input class="tm-radio-group-1 with-gap" name="q1" type="radio" value="q1_a2">
                                <span>B. Morbi faucibus tellus</span>
                            </div>
                            <img src="img/img-3x2-2.jpg" alt="Image">
                        </label>
                        <label class="tm-q-choice">
                            <div class="mb-3">
                                <input class="tm-radio-group-1 with-gap" name="q1" type="radio" value="q1_a3">
                                <span>C. Ut ullamcorper orci eget</span>
                            </div>
                            <img src="img/img-3x2-3.jpg" alt="Image" class="darken">
                        </label>
                        <label class="tm-q-choice">
                            <div class="mb-3">
                                <input class="tm-radio-group-1 with-gap" name="q1" type="radio" value="q1_a4">
                                <span>D. Sed nec faucibus ex</span>
                            </div>
                            <img src="img/img-3x2-4.jpg" alt="Image">
                        </label>
                        <label class="tm-q-choice">
                            <div class="mb-3">
                                <input class="tm-radio-group-1 with-gap" name="q1" type="radio" value="q1_a5">
                                <span>E. Maecenas pretium</span>
                            </div>
                            <img src="img/img-3x2-5.jpg" alt="Image">
                        </label>
                    </div>
                </div> <!-- col-12 -->
                <div class="col-12">
                    <hr>
                </div>
                <div class="tlinks">Collect from <a href="http://www.cssmoban.com/" title="网站模板">网站模板</a></div>
                 <!-- col-12 -->
                <div class="col-12">
                    
                </div>
                 <!-- col-12 -->
                
                
                <div class="col-12 text-center tm-submit-container">
                    <input type="button" onclick="javascript:location.href='loginpage.php'" value="Login">
                </div>
                <div class="col-12">
                    
                </div>
            </div> <!-- row -->
        </form>
        <div class="row">
          <div class="col-12">
                
            </div>
        </div>
    </div>
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/materialize.min.js"></script>
    <script>

        // Parallax function
        // https://codepen.io/roborich/pen/wpAsm
        var background_image_parallax = function ($object, multiplier) {
            multiplier = typeof multiplier !== 'undefined' ? multiplier : 0.5;
            multiplier = 1 - multiplier;
            var $doc = $(document);
            $object.css({ "background-attatchment": "fixed" });
            $(window).scroll(function () {
                var from_top = $doc.scrollTop(),
                    bg_css = 'center ' + (multiplier * from_top - 200) + 'px';
                $object.css({ "background-position": bg_css });
            });
        };

        /**
         * detect IE
         * returns version of IE or false, if browser is not Internet Explorer
         */
        function detectIE() {
            var ua = window.navigator.userAgent;

            var msie = ua.indexOf('MSIE ');
            if (msie > 0) {
                // IE 10 or older => return version number
                return parseInt(ua.substring(msie + 5, ua.indexOf('.', msie)), 10);
            }

            var trident = ua.indexOf('Trident/');
            if (trident > 0) {
                // IE 11 => return version number
                var rv = ua.indexOf('rv:');
                return parseInt(ua.substring(rv + 3, ua.indexOf('.', rv)), 10);
            }

            // var edge = ua.indexOf('Edge/');
            // if (edge > 0) {
            //     // Edge (IE 12+) => return version number
            //     return parseInt(ua.substring(edge + 5, ua.indexOf('.', edge)), 10);
            // }

            // other browser
            return false;
        }

        $(document).ready(function () {

            // Detect IE
            if (detectIE()) {
                alert('Please use the latest version of Chrome, Firefox, or Edge for best browsing experience.');
            }

            $('select').formSelect();
            // Parallax image background
            background_image_parallax($(".tm-parallax"), 0.40);

            // Darken image when its radio button is selected
            $(".tm-radio-group-1").click(function () {
                $('.tm-radio-group-1').parent().siblings("img").removeClass("darken");
                $(this).parent().siblings("img").addClass("darken");
            });

            $(".tm-radio-group-2").click(function () {
                $('.tm-radio-group-2').parent().siblings("img").removeClass("darken");
                $(this).parent().siblings("img").addClass("darken");
            });

            $(".tm-checkbox").click(function () {
                $(this).parent().siblings("img").toggleClass("darken");
            })
        });
    </script>



</body></html>