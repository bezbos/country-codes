// Simply copy/paste these into your C# project.

// Country call numbers only.
var codesOnly = new string[236] { "+7 840", "+93", "+355", "+213", "+1 684", "+376", "+244", "+1 264", "+1 268", "+54", "+374", "+297", "+247", "+61", "+672", "+43", "+994", "+1 242", "+973", "+880", "+1 246", "+1 268", "+375", "+32", "+501", "+229", "+1 441", "+975", "+591", "+387", "+267", "+55", "+246", "+1 284", "+673", "+359", "+226", "+257", "+855", "+237", "+1", "+238", "+345", "+236", "+235", "+56", "+86", "+61", "+61", "+57", "+269", "+242", "+243", "+682", "+506", "+385", "+53", "+599", "+537", "+420", "+45", "+246", "+253", "+1 767", "+1 809", "+670", "+56", "+593", "+20", "+503", "+240", "+291", "+372", "+251", "+500", "+298", "+679", "+358", "+33", "+596", "+594", "+689", "+241", "+220", "+995", "+49", "+233", "+350", "+30", "+299", "+1 473", "+590", "+1 671", "+502", "+224", "+245", "+595", "+509", "+504", "+852", "+36", "+354", "+91", "+62", "+98", "+964", "+353", "+972", "+39", "+225", "+1 876", "+81", "+962", "+7 7", "+254", "+686", "+965", "+996", "+856", "+371", "+961", "+266", "+231", "+218", "+423", "+370", "+352", "+853", "+389", "+261", "+265", "+60", "+960", "+223", "+356", "+692", "+596", "+222", "+230", "+262", "+52", "+691", "+1 808", "+373", "+377", "+976", "+382", "+1664", "+212", "+95", "+264", "+674", "+977", "+31", "+599", "+1 869", "+687", "+64", "+505", "+227", "+234", "+683", "+672", "+850", "+1 670", "+47", "+968", "+92", "+680", "+970", "+507", "+675", "+595", "+51", "+63", "+48", "+351", "+1 787", "+974", "+262", "+40", "+7", "+250", "+685", "+378", "+966", "+221", "+381", "+248", "+232", "+65", "+421", "+386", "+677", "+27", "+500", "+82", "+34", "+94", "+249", "+597", "+268", "+46", "+41", "+963", "+886", "+992", "+255", "+66", "+670", "+228", "+690", "+676", "+1 868", "+216", "+90", "+993", "+1 649", "+688", "+1 340", "+256", "+380", "+971", "+44", "+1", "+598", "+998", "+678", "+58", "+84", "+1 808", "+681", "+967", "+260", "+255", "+263" };

// Codes with country names.
public class CountryCode
{
  public string Code { get; set; }
  public string Name { get; set; }
}

var codesWithCountryname  = new CountryCode[236] { new CountryCode { Code = "+7 840", Name = "Abkhazia" }, new CountryCode { Code = "+93", Name = "Afghanistan" }, new CountryCode { Code = "+355", Name = "Albania" }, new CountryCode { Code = "+213", Name = "Algeria" }, new CountryCode { Code = "+1 684", Name = "American Samoa" }, new CountryCode { Code = "+376", Name = "Andorra" }, new CountryCode { Code = "+244", Name = "Angola" }, new CountryCode { Code = "+1 264", Name = "Anguilla" }, new CountryCode { Code = "+1 268", Name = "Antigua and Barbuda" }, new CountryCode { Code = "+54", Name = "Argentina" }, new CountryCode { Code = "+374", Name = "Armenia" }, new CountryCode { Code = "+297", Name = "Aruba" }, new CountryCode { Code = "+247", Name = "Ascension" }, new CountryCode { Code = "+61", Name = "Australia" }, new CountryCode { Code = "+672", Name = "Australian External Territories" }, new CountryCode { Code = "+43", Name = "Austria" }, new CountryCode { Code = "+994", Name = "Azerbaijan" }, new CountryCode { Code = "+1 242", Name = "Bahamas" }, new CountryCode { Code = "+973", Name = "Bahrain" }, new CountryCode { Code = "+880", Name = "Bangladesh" }, new CountryCode { Code = "+1 246", Name = "Barbados" }, new CountryCode { Code = "+1 268", Name = "Barbuda" }, new CountryCode { Code = "+375", Name = "Belarus" }, new CountryCode { Code = "+32", Name = "Belgium" }, new CountryCode { Code = "+501", Name = "Belize" }, new CountryCode { Code = "+229", Name = "Benin" }, new CountryCode { Code = "+1 441", Name = "Bermuda" }, new CountryCode { Code = "+975", Name = "Bhutan" }, new CountryCode { Code = "+591", Name = "Bolivia" }, new CountryCode { Code = "+387", Name = "Bosnia and Herzegovina" }, new CountryCode { Code = "+267", Name = "Botswana" }, new CountryCode { Code = "+55", Name = "Brazil" }, new CountryCode { Code = "+246", Name = "British Indian Ocean Territory" }, new CountryCode { Code = "+1 284", Name = "British Virgin Islands" }, new CountryCode { Code = "+673", Name = "Brunei" }, new CountryCode { Code = "+359", Name = "Bulgaria" }, new CountryCode { Code = "+226", Name = "Burkina Faso" }, new CountryCode { Code = "+257", Name = "Burundi" }, new CountryCode { Code = "+855", Name = "Cambodia" }, new CountryCode { Code = "+237", Name = "Cameroon" }, new CountryCode { Code = "+1", Name = "Canada" }, new CountryCode { Code = "+238", Name = "Cape Verde" }, new CountryCode { Code = "+345", Name = "Cayman Islands" }, new CountryCode { Code = "+236", Name = "Central African Republic" }, new CountryCode { Code = "+235", Name = "Chad" }, new CountryCode { Code = "+56", Name = "Chile" }, new CountryCode { Code = "+86", Name = "China" }, new CountryCode { Code = "+61", Name = "Christmas Island" }, new CountryCode { Code = "+61", Name = "Cocos - Keeling Islands" }, new CountryCode { Code = "+57", Name = "Colombia" }, new CountryCode { Code = "+269", Name = "Comoros" }, new CountryCode { Code = "+242", Name = "Congo" }, new CountryCode { Code = "+243", Name = "Congo, Dem.Rep.of(Zaire)" }, new CountryCode { Code = "+682", Name = "Cook Islands" }, new CountryCode { Code = "+506", Name = "Costa Rica" }, new CountryCode { Code = "+385", Name = "Croatia" }, new CountryCode { Code = "+53", Name = "Cuba" }, new CountryCode { Code = "+599", Name = "Curacao" }, new CountryCode { Code = "+537", Name = "Cyprus" }, new CountryCode { Code = "+420", Name = "Czech Republic" }, new CountryCode { Code = "+45", Name = "Denmark" }, new CountryCode { Code = "+246", Name = "Diego Garcia" }, new CountryCode { Code = "+253", Name = "Djibouti" }, new CountryCode { Code = "+1 767", Name = "Dominica" }, new CountryCode { Code = "+1 809", Name = "Dominican Republic" }, new CountryCode { Code = "+670", Name = "East Timor" }, new CountryCode { Code = "+56", Name = "Easter Island" }, new CountryCode { Code = "+593", Name = "Ecuador" }, new CountryCode { Code = "+20", Name = "Egypt" }, new CountryCode { Code = "+503", Name = "El Salvador" }, new CountryCode { Code = "+240", Name = "Equatorial Guinea" }, new CountryCode { Code = "+291", Name = "Eritrea" }, new CountryCode { Code = "+372", Name = "Estonia" }, new CountryCode { Code = "+251", Name = "Ethiopia" }, new CountryCode { Code = "+500", Name = "Falkland Islands" }, new CountryCode { Code = "+298", Name = "Faroe Islands" }, new CountryCode { Code = "+679", Name = "Fiji" }, new CountryCode { Code = "+358", Name = "Finland" }, new CountryCode { Code = "+33", Name = "France" }, new CountryCode { Code = "+596", Name = "French Antilles" }, new CountryCode { Code = "+594", Name = "French Guiana" }, new CountryCode { Code = "+689", Name = "French Polynesia" }, new CountryCode { Code = "+241", Name = "Gabon" }, new CountryCode { Code = "+220", Name = "Gambia" }, new CountryCode { Code = "+995", Name = "Georgia" }, new CountryCode { Code = "+49", Name = "Germany" }, new CountryCode { Code = "+233", Name = "Ghana" }, new CountryCode { Code = "+350", Name = "Gibraltar" }, new CountryCode { Code = "+30", Name = "Greece" }, new CountryCode { Code = "+299", Name = "Greenland" }, new CountryCode { Code = "+1 473", Name = "Grenada" }, new CountryCode { Code = "+590", Name = "Guadeloupe" }, new CountryCode { Code = "+1 671", Name = "Guam" }, new CountryCode { Code = "+502", Name = "Guatemala" }, new CountryCode { Code = "+224", Name = "Guinea" }, new CountryCode { Code = "+245", Name = "Guinea - Bissau" }, new CountryCode { Code = "+595", Name = "Guyana" }, new CountryCode { Code = "+509", Name = "Haiti" }, new CountryCode { Code = "+504", Name = "Honduras" }, new CountryCode { Code = "+852", Name = "Hong Kong SAR China" }, new CountryCode { Code = "+36", Name = "Hungary" }, new CountryCode { Code = "+354", Name = "Iceland" }, new CountryCode { Code = "+91", Name = "India" }, new CountryCode { Code = "+62", Name = "Indonesia" }, new CountryCode { Code = "+98", Name = "Iran" }, new CountryCode { Code = "+964", Name = "Iraq" }, new CountryCode { Code = "+353", Name = "Ireland" }, new CountryCode { Code = "+972", Name = "Israel" }, new CountryCode { Code = "+39", Name = "Italy" }, new CountryCode { Code = "+225", Name = "Ivory Coast" }, new CountryCode { Code = "+1 876", Name = "Jamaica" }, new CountryCode { Code = "+81", Name = "Japan" }, new CountryCode { Code = "+962", Name = "Jordan" }, new CountryCode { Code = "+7 7", Name = "Kazakhstan" }, new CountryCode { Code = "+254", Name = "Kenya" }, new CountryCode { Code = "+686", Name = "Kiribati" }, new CountryCode { Code = "+965", Name = "Kuwait" }, new CountryCode { Code = "+996", Name = "Kyrgyzstan" }, new CountryCode { Code = "+856", Name = "Laos" }, new CountryCode { Code = "+371", Name = "Latvia" }, new CountryCode { Code = "+961", Name = "Lebanon" }, new CountryCode { Code = "+266", Name = "Lesotho" }, new CountryCode { Code = "+231", Name = "Liberia" }, new CountryCode { Code = "+218", Name = "Libya" }, new CountryCode { Code = "+423", Name = "Liechtenstein" }, new CountryCode { Code = "+370", Name = "Lithuania" }, new CountryCode { Code = "+352", Name = "Luxembourg" }, new CountryCode { Code = "+853", Name = "Macau SAR China" }, new CountryCode { Code = "+389", Name = "Macedonia" }, new CountryCode { Code = "+261", Name = "Madagascar" }, new CountryCode { Code = "+265", Name = "Malawi" }, new CountryCode { Code = "+60", Name = "Malaysia" }, new CountryCode { Code = "+960", Name = "Maldives" }, new CountryCode { Code = "+223", Name = "Mali" }, new CountryCode { Code = "+356", Name = "Malta" }, new CountryCode { Code = "+692", Name = "Marshall Islands" }, new CountryCode { Code = "+596", Name = "Martinique" }, new CountryCode { Code = "+222", Name = "Mauritania" }, new CountryCode { Code = "+230", Name = "Mauritius" }, new CountryCode { Code = "+262", Name = "Mayotte" }, new CountryCode { Code = "+52", Name = "Mexico" }, new CountryCode { Code = "+691", Name = "Micronesia" }, new CountryCode { Code = "+1 808", Name = "Midway Island" }, new CountryCode { Code = "+373", Name = "Moldova" }, new CountryCode { Code = "+377", Name = "Monaco" }, new CountryCode { Code = "+976", Name = "Mongolia" }, new CountryCode { Code = "+382", Name = "Montenegro" }, new CountryCode { Code = "+1664", Name = "Montserrat" }, new CountryCode { Code = "+212", Name = "Morocco" }, new CountryCode { Code = "+95", Name = "Myanmar" }, new CountryCode { Code = "+264", Name = "Namibia" }, new CountryCode { Code = "+674", Name = "Nauru" }, new CountryCode { Code = "+977", Name = "Nepal" }, new CountryCode { Code = "+31", Name = "Netherlands" }, new CountryCode { Code = "+599", Name = "Netherlands Antilles" }, new CountryCode { Code = "+1 869", Name = "Nevis" }, new CountryCode { Code = "+687", Name = "New Caledonia" }, new CountryCode { Code = "+64", Name = "New Zealand" }, new CountryCode { Code = "+505", Name = "Nicaragua" }, new CountryCode { Code = "+227", Name = "Niger" }, new CountryCode { Code = "+234", Name = "Nigeria" }, new CountryCode { Code = "+683", Name = "Niue" }, new CountryCode { Code = "+672", Name = "Norfolk Island" }, new CountryCode { Code = "+850", Name = "North Korea" }, new CountryCode { Code = "+1 670", Name = "Northern Mariana Islands" }, new CountryCode { Code = "+47", Name = "Norway" }, new CountryCode { Code = "+968", Name = "Oman" }, new CountryCode { Code = "+92", Name = "Pakistan" }, new CountryCode { Code = "+680", Name = "Palau" }, new CountryCode { Code = "+970", Name = "Palestinian Territory" }, new CountryCode { Code = "+507", Name = "Panama" }, new CountryCode { Code = "+675", Name = "Papua New Guinea" }, new CountryCode { Code = "+595", Name = "Paraguay" }, new CountryCode { Code = "+51", Name = "Peru" }, new CountryCode { Code = "+63", Name = "Philippines" }, new CountryCode { Code = "+48", Name = "Poland" }, new CountryCode { Code = "+351", Name = "Portugal" }, new CountryCode { Code = "+1 787", Name = "Puerto Rico" }, new CountryCode { Code = "+974", Name = "Qatar" }, new CountryCode { Code = "+262", Name = "Reunion" }, new CountryCode { Code = "+40", Name = "Romania" }, new CountryCode { Code = "+7", Name = "Russia" }, new CountryCode { Code = "+250", Name = "Rwanda" }, new CountryCode { Code = "+685", Name = "Samoa" }, new CountryCode { Code = "+378", Name = "San Marino" }, new CountryCode { Code = "+966", Name = "Saudi Arabia" }, new CountryCode { Code = "+221", Name = "Senegal" }, new CountryCode { Code = "+381", Name = "Serbia" }, new CountryCode { Code = "+248", Name = "Seychelles" }, new CountryCode { Code = "+232", Name = "Sierra Leone" }, new CountryCode { Code = "+65", Name = "Singapore" }, new CountryCode { Code = "+421", Name = "Slovakia" }, new CountryCode { Code = "+386", Name = "Slovenia" }, new CountryCode { Code = "+677", Name = "Solomon Islands" }, new CountryCode { Code = "+27", Name = "South Africa" }, new CountryCode { Code = "+500", Name = "South Georgia and the South Sandwich Islands" }, new CountryCode { Code = "+82", Name = "South Korea" }, new CountryCode { Code = "+34", Name = "Spain" }, new CountryCode { Code = "+94", Name = "Sri Lanka" }, new CountryCode { Code = "+249", Name = "Sudan" }, new CountryCode { Code = "+597", Name = "Suriname" }, new CountryCode { Code = "+268", Name = "Swaziland" }, new CountryCode { Code = "+46", Name = "Sweden" }, new CountryCode { Code = "+41", Name = "Switzerland" }, new CountryCode { Code = "+963", Name = "Syria" }, new CountryCode { Code = "+886", Name = "Taiwan" }, new CountryCode { Code = "+992", Name = "Tajikistan" }, new CountryCode { Code = "+255", Name = "Tanzania" }, new CountryCode { Code = "+66", Name = "Thailand" }, new CountryCode { Code = "+670", Name = "Timor Leste" }, new CountryCode { Code = "+228", Name = "Togo" }, new CountryCode { Code = "+690", Name = "Tokelau" }, new CountryCode { Code = "+676", Name = "Tonga" }, new CountryCode { Code = "+1 868", Name = "Trinidad and Tobago" }, new CountryCode { Code = "+216", Name = "Tunisia" }, new CountryCode { Code = "+90", Name = "Turkey" }, new CountryCode { Code = "+993", Name = "Turkmenistan" }, new CountryCode { Code = "+1 649", Name = "Turks and Caicos Islands" }, new CountryCode { Code = "+688", Name = "Tuvalu" }, new CountryCode { Code = "+1 340", Name = "U.S.Virgin Islands" }, new CountryCode { Code = "+256", Name = "Uganda" }, new CountryCode { Code = "+380", Name = "Ukraine" }, new CountryCode { Code = "+971", Name = "United Arab Emirates" }, new CountryCode { Code = "+44", Name = "United Kingdom" }, new CountryCode { Code = "+1", Name = "United States" }, new CountryCode { Code = "+598", Name = "Uruguay" }, new CountryCode { Code = "+998", Name = "Uzbekistan" }, new CountryCode { Code = "+678", Name = "Vanuatu" }, new CountryCode { Code = "+58", Name = "Venezuela" }, new CountryCode { Code = "+84", Name = "Vietnam" }, new CountryCode { Code = "+1 808", Name = "Wake Island" }, new CountryCode { Code = "+681", Name = "Wallis and Futuna" }, new CountryCode { Code = "+967", Name = "Yemen" }, new CountryCode { Code = "+260", Name = "Zambia" }, new CountryCode { Code = "+255", Name = "Zanzibar" }, new CountryCode { Code = "+263", Name = "Zimbabwe" } };
