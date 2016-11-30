//document.onload = startButtonEvents();


function MapEvent() {
    this.allMarkers = [];
    this.mapElement = document.getElementById("mapDiv");
    this.currentLocation = new google.maps.LatLng(39.9078, 32.8252);
    this.mapOptions = {
        
        zoom: 13,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    this.geocoder = new google.maps.Geocoder();
    this.map = new google.maps.Map(this.mapElement, this.mapOptions);

    this.initNewMap = function() {
        //this.map = new google.maps.Map(this.mapElement, this.mapOptions);
    }

    this.initAutocompleteSearchButton = function() {
        var input = document.getElementById('pac-input');
        this.map.controls[google.maps.ControlPosition.TOP_CENTER].push(input);
        var autocomplete = new google.maps.places.Autocomplete(input);
        autocomplete.bindTo('bounds', this.map);

        var tm = function(map, autocomplete) {
            var place = autocomplete.getPlace();
            alert(place == undefined);
            if (!place.geometry) {
                // User entered the name of a Place that was not suggested and
                // pressed the Enter key, or the Place Details request failed.
                window.alert("No details available for input: '" + place.name + "'");
                return;
            }

            if (place.geometry.viewport) {
                map.fitBounds(place.geometry.viewport);
            } else {
                map.setCenter(place.geometry.location);
                map.setZoom(17);
            }
        }

        var placeChanged = tm(this.map, autocomplete);

        autocomplete.addListener('place_changed', placeChanged);
    }


    this.createMarkers = function (markerArray) {
        this.clearAllMarkers();
        //var markerArray = JSON.parse(markers);
        var bounds = new google.maps.LatLngBounds();

        for (var i = 0; i < markerArray.length; i++) {
            var markerPointInfo = markerArray[i];

            var marker = new google.maps.Marker({
                position: { lat: markerPointInfo.Latitude, lng: markerPointInfo.Longtitude },
                title: markerPointInfo.EventName
            });
            marker.setMap(this.map);
            this.allMarkers.push(marker);
            bounds.extend(marker.getPosition());
        }
        if (markerArray.length != 0) {
            this.map.setOptions({ maxZoom: 13 });
            this.map.fitBounds(bounds);
            this.map.setOptions({ maxZoom: undefined });
        }
    }

    this.geocodeAddress = function(addressText, hiddenVal) {
        var outer = this;
        var latLong;
        var ad = addressText;
        this.geocoder.geocode({ 'address': addressText.value },
            function(results, status) {
                //if the service is working properly...
                if (addressText.value.length !== 0) {
                    if (status === google.maps.GeocoderStatus.OK) {
                        latLong = results[0].geometry.location;
                        //outer.map.setCenter(latLong);
                        //outer.map.setZoom(13);
                        hiddenVal.value = "" + latLong.lat() + "," + latLong.lng();


                    } else {
                        alert('Cannot geocode because: ' + status);
                    }
                }
                $('#submit-button').submit();
            });
    }


    this.clearAllMarkers = function() {
        for (var i = 0; i < this.allMarkers.length; i++) {
            var marker = this.allMarkers[i];
            if (marker != null) {
                marker.setMap(null);
            }
        }
        this.allMarkers = [];
    }

}
    function listAddresses() {
        //get text input handler
        var addressField = document.getElementById('addressField');
        geocodeAddress(addressField.value);
    }




//------------------------------------------------------------------------------------------------




//function getPosition(map, geocoder) {
//    var postcode = document.getElementById("postcode").value;

//    geocoder.geocode({ 'address': postcode }, function (results, status) {
//        if (status == google.maps.GeocoderStatus.OK) {
//            var nlatLang = new google.maps.LatLng(results[0].geometry.location.lat(), [0].geometry.location.lng());
//            map.panTo(nlatLang);
//        }
//    });
//}



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

