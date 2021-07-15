
var app = angular.module('myRouteModule', ['ui.router']);
app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("Home");
    $stateProvider
        .state('Home', {
            url: "/Home",
            views: {
                'container-view': {
                    templateUrl: "Home/Index"
                },
                'right-view@Home': {
                    templateUrl: "Home/Privacy"
                }
            }
        })
        .state('Students.Result', {
            url: "/Result",
            views: {
                'container-view': {
                    templateUrl: "Home/Index"
                },
                'right-view@Home': {
                    templateUrl: "Home/Route"
                }
            }

        })
});