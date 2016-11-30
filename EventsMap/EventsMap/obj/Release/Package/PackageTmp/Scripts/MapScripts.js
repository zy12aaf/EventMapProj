//document.onload = startButtonEvents();



function MapEvent() {
    this.allMarkers = [];

    this.mapElement = document.getElementById("mapDiv");
    this.currentLocation = new google.maps.LatLng(39.9078, 32.8252);
    this.mapOptions = {
        center: this.currentLocation,
        zoom: 0,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    this.geocoder = new google.maps.Geocoder();
    this.map = new google.maps.Map(this.mapElement, this.mapOptions);



    this.initNewMap = function() {
        this.map = new google.maps.Map(this.mapElement, this.mapOptions);
    }

    this.createMarkers = function (markers, clearMap) {
        

        var newMarker = markers.replace(/&quot;/g, '"');
        var markerArray = JSON.parse(markers.replace(/&quot;/g, '"'));
        for (var i = 0; i < markerArray.length; i++) {
            var markerPointInfo = markerArray[i];

            var marker = new google.maps.Marker({
                position: { lat: markerPointInfo.Latitude, lng: markerPointInfo.Longtitude },
                map: this.map,
                title: markerPointInfo.EventName
            });
            this.allMarkers.push(marker);
        }
        
    }

    this.clearAllMarkers = function () {
        this.initNewMap();

        //for (var i = 0; i < this.allMarkers.length; i++) {
        //    var marker = this.allMarkers[i];
        //    if (marker != null) {
        //        marker.map = null;
        //    }
        //}
        //this.allMarkers = [];
    }
}


//------------------------------------------------------------------------------------------------
function listAddresses() {
    //get text input handler
    var addressField = document.getElementById('addressField');

    //call the geocoding function
    geocodeAddress(addressField.value);
}

function geocodeAddress(addressText) {
    //real essence, send the geocoding request
    geocoder.geocode({ 'address': addressText }, function (results, status) {
        //if the service is working properly...
        if (status == google.maps.GeocoderStatus.OK) {
            //show the first result on map
            pinpointResult(results[0]);
        } else {
            alert('Cannot geocode because: ' + status);
        }
    });
}

function pinpointResult(result) {
    map.setCenter(result.geometry.location);
    map.setZoom(16);
}

function startButtonEvents() {
    var listAddressBtn = document.getElementById('listAdressBtn');
    listAddressBtn.addEventListener('click', function () {
        listAddresses();
    });
}




//function zoomToIstanbul() {
//    var istanbul = new google.maps.LatLng(41.0579, 29.0340);
//    map.setCenter(istanbul);
//}

//function zoomToStreet() {
//    map.setZoom(18);
//}

//function disableDrag() {
//    map.setOptions({ draggable: false });
//}

//function setMaxZoom() {
//    map.setOptions({ maxZoom: 12 });
//}

//function setMinZoom() {
//    map.setOptions({ minZoom: 5 });
//}

//function changeUI() {
//    map.setOptions({ disableDefaultUI: true });
//}

//function disableScroll() {
//    map.setOptions({ scrollwheel: false });
//}

