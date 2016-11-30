using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public class Location
    {
        public int LocationId       {get;set;}
        public string Address       { get; set; }
        public string Postcode      {get;set;}
        public double Latitude     {get;set;}
        public double Longtitude   {get;set;}
        public Region Region        {get;set;}
        public string EventName     { get; set; }

        private double Distance(double lat1, double lon1, double lat2, double lon2)
        {
            var unit = 'M';
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            if (unit == 'K') {
                dist = dist * 1.609344;
            }
            else if (unit == 'N') {
                dist = dist * 0.8684;
            }
            return (dist);
        }

        public bool WithinDistance(LatLong latLong, int dist)
        {
            var lat1 = this.Latitude;
            var lon1 = this.Longtitude;

            var lat2 = latLong.Latitude;
            var lon2 = latLong.Longtitude;
            var distance = Distance(lat1, lon1, lat2, lon2);
            return distance <= dist;
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts decimal degrees to radians             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private double deg2rad(double deg) {
            return (deg * Math.PI / 180.0);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts radians to decimal degrees             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private double rad2deg(double rad) {
            return (rad / Math.PI * 180.0);
        }
    }
}
