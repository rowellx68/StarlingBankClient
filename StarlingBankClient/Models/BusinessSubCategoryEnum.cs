using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BusinessSubCategoryEnum
    {
        NOT_PROVIDED, //TODO: Write general description for this method
        ART_AND_CRAFT_SUPPLIES, //TODO: Write general description for this method
        ART_DEALERS_AND_GALLERIES, //TODO: Write general description for this method
        CAMERA_AND_PHOTOGRAPHIC_SUPPLIES, //TODO: Write general description for this method
        DIGITAL_ART, //TODO: Write general description for this method
        MEMORABILIA, //TODO: Write general description for this method
        MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC, //TODO: Write general description for this method
        SEWING_NEEDLEWORK_AND_FABRICS, //TODO: Write general description for this method
        STAMP_AND_COIN, //TODO: Write general description for this method
        STATIONARY_PRINTING_AND_WRITING_PAPER, //TODO: Write general description for this method
        VINTAGE_AND_COLLECTIBLES, //TODO: Write general description for this method
        CLOTHING, //TODO: Write general description for this method
        FURNITURE, //TODO: Write general description for this method
        BABY_PRODUCTS_OTHER, //TODO: Write general description for this method
        SAFETY_AND_HEALTH, //TODO: Write general description for this method
        BATH_AND_BODY, //TODO: Write general description for this method
        FRAGRANCES_AND_PERFUMES, //TODO: Write general description for this method
        MAKEUP_AND_COSMETICS, //TODO: Write general description for this method
        AUDIO_BOOKS, //TODO: Write general description for this method
        DIGITAL_CONTENT, //TODO: Write general description for this method
        EDUCATIONAL_AND_TEXTBOOKS, //TODO: Write general description for this method
        FICTION_AND_NONFICTION, //TODO: Write general description for this method
        MAGAZINES, //TODO: Write general description for this method
        BOOKS_PUBLISHING_AND_PRINTING, //TODO: Write general description for this method
        RARE_AND_USED_BOOKS, //TODO: Write general description for this method
        ACCOUNTING, //TODO: Write general description for this method
        ADVERTISING, //TODO: Write general description for this method
        AGRICULTURAL, //TODO: Write general description for this method
        ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES, //TODO: Write general description for this method
        CHEMICALS_AND_ALLIED_PRODUCTS, //TODO: Write general description for this method
        COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS, //TODO: Write general description for this method
        CONSTRUCTION, //TODO: Write general description for this method
        CONSULTING_SERVICES, //TODO: Write general description for this method
        EDUCATIONAL_SERVICES, //TODO: Write general description for this method
        EQUIPMENT_RENTALS_AND_LEASING_SERVICES, //TODO: Write general description for this method
        EQUIPMENT_REPAIR_SERVICES, //TODO: Write general description for this method
        HIRING_SERVICES, //TODO: Write general description for this method
        INDUSTRIAL_AND_MANUFACTURING_SUPPLIES, //TODO: Write general description for this method
        MAILING_LISTS, //TODO: Write general description for this method
        MARKETING, //TODO: Write general description for this method
        MULTILEVEL_MARKETING, //TODO: Write general description for this method
        OFFICE_AND_COMMERCIAL_FURNITURE, //TODO: Write general description for this method
        OFFICE_SUPPLIES_AND_EQUIPMENT, //TODO: Write general description for this method
        PUBLISHING_AND_PRINTING, //TODO: Write general description for this method
        QUICK_COPY_AND_REPRODUCTION_SERVICES, //TODO: Write general description for this method
        SHIPPING_AND_PACKING, //TODO: Write general description for this method
        STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES, //TODO: Write general description for this method
        WHOLESALE, //TODO: Write general description for this method
        CHILDRENS_CLOTHING, //TODO: Write general description for this method
        MENS_CLOTHING, //TODO: Write general description for this method
        WOMENS_CLOTHING, //TODO: Write general description for this method
        SHOES, //TODO: Write general description for this method
        MILITARY_AND_CIVIL_SERVICE_UNIFORMS, //TODO: Write general description for this method
        ACCESSORIES, //TODO: Write general description for this method
        RETAIL_FINE_JEWELRY_AND_WATCHES, //TODO: Write general description for this method
        WHOLESALE_PRECIOUS_STONES_AND_METALS, //TODO: Write general description for this method
        FASHION_JEWELLERY, //TODO: Write general description for this method
        COMPUTER_AND_DATA_PROCESSING_SERVICES, //TODO: Write general description for this method
        DESKTOPS_LAPTOPS_AND_NOTEBOOKS, //TODO: Write general description for this method
        COMPUTER_DIGITAL_CONTENT, //TODO: Write general description for this method
        ECOMMERCE_SERVICES, //TODO: Write general description for this method
        MAINTENANCE_AND_REPAIR_SERVICES, //TODO: Write general description for this method
        MONITORS_AND_PROJECTORS, //TODO: Write general description for this method
        NETWORKING, //TODO: Write general description for this method
        ONLINE_GAMING, //TODO: Write general description for this method
        PARTS_AND_ACCESSORIES, //TODO: Write general description for this method
        PERIPHERALS, //TODO: Write general description for this method
        SOFTWARE, //TODO: Write general description for this method
        TRAINING_SERVICES, //TODO: Write general description for this method
        WEB_HOSTING_AND_DESIGN, //TODO: Write general description for this method
        BUSINESS_AND_SECRETARIAL_SCHOOLS, //TODO: Write general description for this method
        CHILD_DAYCARE_SERVICES, //TODO: Write general description for this method
        DANCE_HALLS_STUDIOS_AND_SCHOOLS, //TODO: Write general description for this method
        VOCATIONAL_AND_TRADE_SCHOOLS, //TODO: Write general description for this method
        CAMERAS_CAMCORDERS_AND_EQUIPMENT, //TODO: Write general description for this method
        CELL_PHONES_PDAS_AND_PAGERS, //TODO: Write general description for this method
        GENERAL_ELECTRONIC_ACCESSORIES, //TODO: Write general description for this method
        HOME_AUDIO, //TODO: Write general description for this method
        HOME_ELECTRONICS, //TODO: Write general description for this method
        SECURITY_AND_SURVEILLANCE, //TODO: Write general description for this method
        TELECOMMUNICATION_EQUIPMENT_AND_SALES, //TODO: Write general description for this method
        TELECOMMUNICATION_SERVICES, //TODO: Write general description for this method
        TELEPHONE_CARDS, //TODO: Write general description for this method
        ENTERTAINMENT_MEMORABILIA, //TODO: Write general description for this method
        MOVIE_TICKETS, //TODO: Write general description for this method
        MOVIES_DVDS_VIDEOTAPES, //TODO: Write general description for this method
        MUSIC_CDS_CASSETTES_AND_ALBUMS, //TODO: Write general description for this method
        CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO, //TODO: Write general description for this method
        CONCERT_TICKETS, //TODO: Write general description for this method
        THEATER_TICKETS, //TODO: Write general description for this method
        TOYS_AND_GAMES, //TODO: Write general description for this method
        ENTERTAINMENT_DIGITAL_CONTENT, //TODO: Write general description for this method
        ENTERTAINERS, //TODO: Write general description for this method
        ONLINE_GAMES, //TODO: Write general description for this method
        VIDEO_GAMES_AND_SYSTEMS, //TODO: Write general description for this method
        FINANCIAL_ACCOUNTING, //TODO: Write general description for this method
        DEBT_COUNSELING_SERVICE, //TODO: Write general description for this method
        FINANCIAL_AND_INVESTMENT_ADVICE, //TODO: Write general description for this method
        REAL_ESTATE_AGENT, //TODO: Write general description for this method
        RENTAL_PROPERTY_MANAGEMENT, //TODO: Write general description for this method
        ALCOHOLIC_BEVERAGES, //TODO: Write general description for this method
        CATERING_SERVICES, //TODO: Write general description for this method
        COFFEE_AND_TEA, //TODO: Write general description for this method
        GOURMET_FOODS, //TODO: Write general description for this method
        SPECIALTY_AND_MISCELLANEOUS_FOOD_STORES, //TODO: Write general description for this method
        RESTAURANT, //TODO: Write general description for this method
        TOBACCO, //TODO: Write general description for this method
        VITAMINS_AND_SUPPLEMENTS, //TODO: Write general description for this method
        FLORIST, //TODO: Write general description for this method
        GIFT_CARD_NOVELTY_AND_SOUVENIR_SHOPS, //TODO: Write general description for this method
        GIFTS_GOURMET_FOODS, //TODO: Write general description for this method
        NURSERY_PLANTS_AND_FLOWERS, //TODO: Write general description for this method
        PARTY_SUPPLIES, //TODO: Write general description for this method
        DENTAL_CARE, //TODO: Write general description for this method
        MEDICAL_CARE, //TODO: Write general description for this method
        MEDICAL_EQUIPMENT_AND_SUPPLIES, //TODO: Write general description for this method
        VISION_CARE, //TODO: Write general description for this method
        HEALTH_VITAMINS_AND_SUPPLEMENTS, //TODO: Write general description for this method
        APPLIANCES, //TODO: Write general description for this method
        HOME_ART_DEALERS_AND_GALLERIES, //TODO: Write general description for this method
        BED_AND_BATH, //TODO: Write general description for this method
        CONSTRUCTION_MATERIAL, //TODO: Write general description for this method
        DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY, //TODO: Write general description for this method
        EXTERMINATING_AND_DISINFECTING_SERVICES, //TODO: Write general description for this method
        FIREPLACE_AND_FIREPLACE_SCREENS, //TODO: Write general description for this method
        HOME_FURNITURE, //TODO: Write general description for this method
        GARDEN_SUPPLIES, //TODO: Write general description for this method
        GLASS_PAINT_AND_WALLPAPER, //TODO: Write general description for this method
        HARDWARE_AND_TOOLS, //TODO: Write general description for this method
        HOME_DECOR, //TODO: Write general description for this method
        HOUSEWARES, //TODO: Write general description for this method
        KITCHENWARE, //TODO: Write general description for this method
        LANDSCAPING, //TODO: Write general description for this method
        RUGS_AND_CARPETS, //TODO: Write general description for this method
        SECURITY_AND_SURVEILLANCE_EQUIPMENT, //TODO: Write general description for this method
        SWIMMING_POOLS_AND_SPAS, //TODO: Write general description for this method
        CHARITY, //TODO: Write general description for this method
        POLITICAL, //TODO: Write general description for this method
        RELIGIOUS, //TODO: Write general description for this method
        OTHER, //TODO: Write general description for this method
        PERSONAL, //TODO: Write general description for this method
        EDUCATIONAL, //TODO: Write general description for this method
        MEDICATION_AND_SUPPLEMENTS, //TODO: Write general description for this method
        PET_SHOPS_PET_FOOD_AND_SUPPLIES, //TODO: Write general description for this method
        SPECIALTY_OR_RARE_PETS, //TODO: Write general description for this method
        VETERINARY_SERVICES, //TODO: Write general description for this method
        MEMBERSHIP_SERVICES, //TODO: Write general description for this method
        MERCHANDISE, //TODO: Write general description for this method
        SERVICES_NOT_ELSEWHERE_CLASSIFIED, //TODO: Write general description for this method
        RETAIL_CHEMICALS_AND_ALLIED_PRODUCTS, //TODO: Write general description for this method
        DEPARTMENT_STORE, //TODO: Write general description for this method
        DISCOUNT_STORE, //TODO: Write general description for this method
        DURABLE_GOODS, //TODO: Write general description for this method
        NONDURABLE_GOODS, //TODO: Write general description for this method
        USED_AND_SECONDHAND_STORE, //TODO: Write general description for this method
        VARIETY_STORE, //TODO: Write general description for this method
        SERVICES_ADVERTISING, //TODO: Write general description for this method
        SHOPPING_SERVICES_AND_BUYING_CLUBS, //TODO: Write general description for this method
        CAREER_SERVICES, //TODO: Write general description for this method
        CARPENTRY, //TODO: Write general description for this method
        CHILD_CARE_SERVICES, //TODO: Write general description for this method
        CLEANING_AND_MAINTENANCE, //TODO: Write general description for this method
        COMMERCIAL_PHOTOGRAPHY, //TODO: Write general description for this method
        SERVICES_COMPUTER_AND_DATA_PROCESSING_SERVICES, //TODO: Write general description for this method
        COMPUTER_NETWORK_SERVICES, //TODO: Write general description for this method
        SERVICES_CONSULTING_SERVICES, //TODO: Write general description for this method
        COUNSELING_SERVICES, //TODO: Write general description for this method
        COURIER_SERVICES, //TODO: Write general description for this method
        SERVICES_DENTAL_CARE, //TODO: Write general description for this method
        SERVICES_ECOMMERCE_SERVICES, //TODO: Write general description for this method
        ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR, //TODO: Write general description for this method
        ENTERTAINMENT, //TODO: Write general description for this method
        EQUIPMENT_RENTAL_AND_LEASING_SERVICES, //TODO: Write general description for this method
        EVENT_AND_WEDDING_PLANNING, //TODO: Write general description for this method
        GENERAL_CONTRACTORS, //TODO: Write general description for this method
        GRAPHIC_AND_COMMERCIAL_DESIGN, //TODO: Write general description for this method
        HEALTH_AND_BEAUTY_SPAS, //TODO: Write general description for this method
        IDS_LICENSES_AND_PASSPORTS, //TODO: Write general description for this method
        IMPORTING_AND_EXPORTING, //TODO: Write general description for this method
        INFORMATION_RETRIEVAL_SERVICES, //TODO: Write general description for this method
        LANDSCAPING_AND_HORTICULTURAL, //TODO: Write general description for this method
        LEGAL_SERVICES_AND_ATTORNEYS, //TODO: Write general description for this method
        LOCAL_DELIVERY_SERVICE, //TODO: Write general description for this method
        SERVICES_MEDICAL_CARE, //TODO: Write general description for this method
        MEMBERSHIP_CLUBS_AND_ORGANIZATIONS, //TODO: Write general description for this method
        SERVICES_MISC_PUBLISHING_AND_PRINTING, //TODO: Write general description for this method
        MOVING_AND_STORAGE, //TODO: Write general description for this method
        PHOTOFINISHING, //TODO: Write general description for this method
        PHOTOGRAPHIC_STUDIOS__PORTRAITS, //TODO: Write general description for this method
        PROTECTIVE_AND_SECURITY_SERVICES, //TODO: Write general description for this method
        SERVICES_QUICK_COPY_AND_REPRODUCTION_SERVICES, //TODO: Write general description for this method
        RADIO_TELEVISION_AND_STEREO_REPAIR, //TODO: Write general description for this method
        REAL_ESTATE_AGENT_1, //TODO: Write general description for this method
        SERVICES_RENTAL_PROPERTY_MANAGEMENT, //TODO: Write general description for this method
        REUPHOLSTERY_AND_FURNITURE_REPAIR, //TODO: Write general description for this method
        SERVICES_SERVICES_NOT_ELSEWHERE_CLASSIFIED, //TODO: Write general description for this method
        SERVICES_SHIPPING_AND_PACKING, //TODO: Write general description for this method
        SWIMMING_POOL_SERVICES, //TODO: Write general description for this method
        TAILORS_AND_ALTERATIONS, //TODO: Write general description for this method
        TELECOMMUNICATION_SERVICE, //TODO: Write general description for this method
        UTILITIES, //TODO: Write general description for this method
        SERVICES_VISION_CARE, //TODO: Write general description for this method
        WATCH_CLOCK_AND_JEWELRY_REPAIR, //TODO: Write general description for this method
        ATHLETIC_SHOES, //TODO: Write general description for this method
        BICYCLE_SHOP_SERVICE_AND_REPAIR, //TODO: Write general description for this method
        BOATING_SAILING_AND_ACCESSORIES, //TODO: Write general description for this method
        CAMPING_AND_OUTDOORS, //TODO: Write general description for this method
        SPORTS_DANCE_HALLS_STUDIOS_AND_SCHOOLS, //TODO: Write general description for this method
        EXERCISE_AND_FITNESS, //TODO: Write general description for this method
        FAN_GEAR_AND_MEMORABILIA, //TODO: Write general description for this method
        HUNTING, //TODO: Write general description for this method
        MARTIAL_ARTS_WEAPONS, //TODO: Write general description for this method
        SPORT_GAMES_AND_TOYS, //TODO: Write general description for this method
        SPORTING_EQUIPMENT, //TODO: Write general description for this method
        SPORTS_SWIMMING_POOLS_AND_SPAS, //TODO: Write general description for this method
        ARTS_AND_CRAFTS, //TODO: Write general description for this method
        HOBBIES_CAMERA_AND_PHOTOGRAPHIC_SUPPLIES, //TODO: Write general description for this method
        HOBBY_TOY_AND_GAME_SHOPS, //TODO: Write general description for this method
        HOBBIES_MEMORABILIA, //TODO: Write general description for this method
        MUSIC_STORE__INSTRUMENTS_AND_SHEET_MUSIC1, //TODO: Write general description for this method
        HOBBIES_STAMP_AND_COIN, //TODO: Write general description for this method
        HOBBIES_STATIONARY_PRINTING_AND_WRITING_PAPER, //TODO: Write general description for this method
        HOBBIES_VINTAGE_AND_COLLECTIBLES, //TODO: Write general description for this method
        HOBBIES_VIDEO_GAMES_AND_SYSTEMS, //TODO: Write general description for this method
        AIRLINE, //TODO: Write general description for this method
        AUTO_RENTAL, //TODO: Write general description for this method
        BUS_LINE, //TODO: Write general description for this method
        CRUISES, //TODO: Write general description for this method
        LODGING_AND_ACCOMMODATIONS, //TODO: Write general description for this method
        LUGGAGE_AND_LEATHER_GOODS, //TODO: Write general description for this method
        RECREATIONAL_SERVICES, //TODO: Write general description for this method
        SPORTING_AND_RECREATION_CAMPS, //TODO: Write general description for this method
        TAXICABS_AND_LIMOUSINES, //TODO: Write general description for this method
        TIMESHARES, //TODO: Write general description for this method
        TOURS, //TODO: Write general description for this method
        TRAILER_PARKS_OR_CAMPGROUNDS, //TODO: Write general description for this method
        TRANSPORTATION_SERVICES__OTHER, //TODO: Write general description for this method
        TRAVEL_AGENCY, //TODO: Write general description for this method
        NEW_PARTS_AND_SUPPLIES__MOTOR_VEHICLE, //TODO: Write general description for this method
        USED_PARTS__MOTOR_VEHICLE, //TODO: Write general description for this method
        AUDIO_AND_VIDEO, //TODO: Write general description for this method
        AUTO_BODY_REPAIR_AND_PAINT, //TODO: Write general description for this method
        SERVICES_AUTO_RENTAL, //TODO: Write general description for this method
        AUTO_SERVICE, //TODO: Write general description for this method
        AUTOMOTIVE_TIRE_SUPPLY_AND_SERVICE, //TODO: Write general description for this method
        BOAT_RENTAL_AND_LEASES, //TODO: Write general description for this method
        CAR_WASH, //TODO: Write general description for this method
        MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL, //TODO: Write general description for this method
        TOOLS_AND_EQUIPMENT, //TODO: Write general description for this method
        TOWING_SERVICE, //TODO: Write general description for this method
        TRUCK_AND_UTILITY_TRAILER_RENTAL, //TODO: Write general description for this method
        VEHICLE_ACCESSORIES, //TODO: Write general description for this method
        ARCHITECT_STRUCTURAL_ENGINEER_OR_SURVEYOR, //TODO: Write general description for this method
        ACCOUNTANCY_AND_BOOKKEEPING, //TODO: Write general description for this method
        BUSINESS_SERVICES, //TODO: Write general description for this method
        FINANCIAL_OR_INVESTMENT_ADVICE, //TODO: Write general description for this method
        MORTGAGE_BROKERS, //TODO: Write general description for this method
        SOFTWARE_AND_IT, //TODO: Write general description for this method
        WEBSITE_DEVELOPMENT, //TODO: Write general description for this method
        MANAGEMENT_CONSULTANCY, //TODO: Write general description for this method
        PROJECT_MANAGEMENT, //TODO: Write general description for this method
        MARKETING_ADVERTISING_AND_DESIGN, //TODO: Write general description for this method
        GRAPHIC_DESIGN_AND_ILLUSTRATION, //TODO: Write general description for this method
        INTERIOR_DESIGN, //TODO: Write general description for this method
        RECRUITMENT_AND_HIRING, //TODO: Write general description for this method
        LEGAL, //TODO: Write general description for this method
        PHOTOGRAPHY, //TODO: Write general description for this method
        SECURITY, //TODO: Write general description for this method
        PROFESSIONAL_SERVICES_OTHER, //TODO: Write general description for this method
        PERSONAL_TRAINER, //TODO: Write general description for this method
        SPORTS_COACH, //TODO: Write general description for this method
        SPORTS_CLUB, //TODO: Write general description for this method
        SPORTS_AND_FITNESS_VENUE, //TODO: Write general description for this method
        GYM_OPERATOR, //TODO: Write general description for this method
        CLASS_INSTRUCTOR, //TODO: Write general description for this method
        EXERCISE_AND_FITNESS_OTHER, //TODO: Write general description for this method
        RESTAURANT_OR_CAFE, //TODO: Write general description for this method
        TAKEAWAY, //TODO: Write general description for this method
        STREET_FOOD_OR_MARKET_STALL, //TODO: Write general description for this method
        RETAIL, //TODO: Write general description for this method
        WHOLESALING, //TODO: Write general description for this method
        SALONS, //TODO: Write general description for this method
        AT_HOME_SERVICES, //TODO: Write general description for this method
        LICENSED_RETAIL, //TODO: Write general description for this method
        LICENSED_FOOD_VENUE, //TODO: Write general description for this method
        RETAIL_BARS_AND_RESTAURANTS_OTHER, //TODO: Write general description for this method
        DIGITAL_CONTENT_OR_GAMES, //TODO: Write general description for this method
        PROMOTION_AND_PUBLISHING, //TODO: Write general description for this method
        CATERING, //TODO: Write general description for this method
        ENTERTAINERS_AND_DJS, //TODO: Write general description for this method
        EVENTS_AND_WEDDINGS, //TODO: Write general description for this method
        EVENTS_PRODUCTS, //TODO: Write general description for this method
        EVENTS_STAFFING_AND_SERVICES, //TODO: Write general description for this method
        TRAVEL_AGENT, //TODO: Write general description for this method
        TOUR_GUIDE, //TODO: Write general description for this method
        LODGING_AND_ACCOMMODATION, //TODO: Write general description for this method
        TV_AND_RADIO, //TODO: Write general description for this method
        MUSICIAN_OR_GROUPS, //TODO: Write general description for this method
        ENTERTAINMENT_AND_TRAVEL_OTHER, //TODO: Write general description for this method
        DOCTOR_NURSE_OR_MIDWIFE, //TODO: Write general description for this method
        PHARMACY, //TODO: Write general description for this method
        PERSONAL_AND_SOCIAL_CARE, //TODO: Write general description for this method
        PHYSIOTHERAPIST, //TODO: Write general description for this method
        NUTRITION_AND_DIET, //TODO: Write general description for this method
        MENTAL_HEALTH_AND_COUNSELLING, //TODO: Write general description for this method
        MEDICAL_EQUIPMENT_AND_SUPPLIERS, //TODO: Write general description for this method
        DENTAL, //TODO: Write general description for this method
        OPTICIAN, //TODO: Write general description for this method
        OTHER_MEDICAL_THERAPY, //TODO: Write general description for this method
        CHIROPRACTOR_OR_OSTEOPATH, //TODO: Write general description for this method
        PODIATRIST, //TODO: Write general description for this method
        COMPLIMENTARY_AND_ALTERNATIVE_MEDICINE, //TODO: Write general description for this method
        HEALTH_AND_SOCIAL_CARE_OTHER, //TODO: Write general description for this method
        HGV_OR_BUS_OR_COACH_DRIVER, //TODO: Write general description for this method
        TAXI_OR_PRIVATE_HIRE_DRIVER, //TODO: Write general description for this method
        TRAIN_DRIVER, //TODO: Write general description for this method
        OTHER_PROFESSIONAL_DRIVER, //TODO: Write general description for this method
        HOME_DELIVERY_AND_COURIER_FIRMS, //TODO: Write general description for this method
        HAULAGE_FIRMS, //TODO: Write general description for this method
        TAXI_OR_PRIVATE_HIRE_OPERATOR, //TODO: Write general description for this method
        MINIBUS_OR_COACH_OPERATOR, //TODO: Write general description for this method
        VEHICLE_REPAIR_AND_MAINTENANCE, //TODO: Write general description for this method
        NEW_CARS_OR_VEHICLE_SALES, //TODO: Write general description for this method
        VEHICLE_RENTAL, //TODO: Write general description for this method
        BICYCLE_SHOPS, //TODO: Write general description for this method
        USED_CAR_OR_VEHICLE_SALES, //TODO: Write general description for this method
        VEHICLE_PARTS, //TODO: Write general description for this method
        CAR_WASHING, //TODO: Write general description for this method
        TRANSPORT_AND_VEHICLES_OTHER, //TODO: Write general description for this method
        CLEANING, //TODO: Write general description for this method
        DECORATING, //TODO: Write general description for this method
        ELECTRICIAN, //TODO: Write general description for this method
        PLUMBER, //TODO: Write general description for this method
        GAS_AND_HEATING, //TODO: Write general description for this method
        CARPENTRY_TRADE, //TODO: Write general description for this method
        ROOFING, //TODO: Write general description for this method
        GARDENING_AND_TREE_SURGERY, //TODO: Write general description for this method
        GENERAL_CONTRACTOR, //TODO: Write general description for this method
        CONSTRUCTION_SUPPLIER, //TODO: Write general description for this method
        WASTE_AND_RECYCLING, //TODO: Write general description for this method
        SITE_AND_BUILDING_MANAGEMENT, //TODO: Write general description for this method
        CONSTRUCTION_TRADES_AND_CLEANING_OTHER, //TODO: Write general description for this method
        PROPERTY_OWNER, //TODO: Write general description for this method
        PROPERTY_INVESTOR, //TODO: Write general description for this method
        PROPERTY_INVESTMENT_FUND, //TODO: Write general description for this method
        RESIDENTS_ASSOCIATION, //TODO: Write general description for this method
        LEASEHOLD_OR_FREEHOLD, //TODO: Write general description for this method
        HOLIDAY_OR_SHORT_TERM_LETS, //TODO: Write general description for this method
        PROPERTY_REDEVELOPMENT, //TODO: Write general description for this method
        ESTATE_AGENT, //TODO: Write general description for this method
        PROPERTY_MANAGEMENT, //TODO: Write general description for this method
        STORAGE, //TODO: Write general description for this method
        PROPERTY_OTHER, //TODO: Write general description for this method
        PERSONAL_TUTOR, //TODO: Write general description for this method
        MUSIC_TEACHERS, //TODO: Write general description for this method
        PROFESSIONAL_TRAINER, //TODO: Write general description for this method
        PUBLIC_SPEAKING, //TODO: Write general description for this method
        NURSERY, //TODO: Write general description for this method
        CHILDMINDER, //TODO: Write general description for this method
        NANNY_OR_AU_PAIR, //TODO: Write general description for this method
        CHILDRENS_ACTIVITIES, //TODO: Write general description for this method
        STUDENT_RECRUITMENT, //TODO: Write general description for this method
        SCHOOLS_COLLEGES_AND_TRAINING, //TODO: Write general description for this method
        EDUCATION_AND_SKILLS_OTHER, //TODO: Write general description for this method
        ANIMALS, //TODO: Write general description for this method
        ARTS_CULTURE_AND_HUMANITIES, //TODO: Write general description for this method
        COMMUNITY_DEVELOPMENT, //TODO: Write general description for this method
        EDUCATION, //TODO: Write general description for this method
        ENVIRONMENT, //TODO: Write general description for this method
        HEALTH_AND_DISEASE, //TODO: Write general description for this method
        HUMAN_AND_CIVIL_RIGHTS, //TODO: Write general description for this method
        CHILDREN_YOUTH_AND_FAMILY, //TODO: Write general description for this method
        HOMELESSNESS, //TODO: Write general description for this method
        INTERNATIONAL, //TODO: Write general description for this method
        RESEARCH_AND_PUBLIC_POLICY, //TODO: Write general description for this method
        RELIGION, //TODO: Write general description for this method
        NON_PROFIT_OTHER, //TODO: Write general description for this method
        MANUFACTURING, //TODO: Write general description for this method
        INDUSTRIAL_ENGINEER, //TODO: Write general description for this method
        FOOD_OR_DRINK_PRODUCTION, //TODO: Write general description for this method
        RESEARCH_AND_DEVELOPMENT, //TODO: Write general description for this method
        LIVESTOCK_FARMING, //TODO: Write general description for this method
        CROP_FARMING, //TODO: Write general description for this method
        HORTICULTURE_OR_PLANT_NURSERY, //TODO: Write general description for this method
        FORESTRY, //TODO: Write general description for this method
        VETERINARY, //TODO: Write general description for this method
        SUPPLIER_TO_AGRICULTURE_OR_INDUSTRY, //TODO: Write general description for this method
        EQUESTRIAN, //TODO: Write general description for this method
        ANIMAL_CARE, //TODO: Write general description for this method
        MANUFACTURING_RND_AND_AGRICULTURE_OTHER, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type BusinessSubCategoryEnum
    /// </summary>
    public static class BusinessSubCategoryEnumHelper
    {
        //string values corresponding the enum elements
        private static readonly List<string> StringValues = new List<string> { "NOT_PROVIDED", "ART_AND_CRAFT_SUPPLIES", "ART_DEALERS_AND_GALLERIES", "CAMERA_AND_PHOTOGRAPHIC_SUPPLIES", "DIGITAL_ART", "MEMORABILIA", "MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC", "SEWING_NEEDLEWORK_AND_FABRICS", "STAMP_AND_COIN", "STATIONARY_PRINTING_AND_WRITING_PAPER", "VINTAGE_AND_COLLECTIBLES", "CLOTHING", "FURNITURE", "BABY_PRODUCTS_OTHER", "SAFETY_AND_HEALTH", "BATH_AND_BODY", "FRAGRANCES_AND_PERFUMES", "MAKEUP_AND_COSMETICS", "AUDIO_BOOKS", "DIGITAL_CONTENT", "EDUCATIONAL_AND_TEXTBOOKS", "FICTION_AND_NONFICTION", "MAGAZINES", "BOOKS_PUBLISHING_AND_PRINTING", "RARE_AND_USED_BOOKS", "ACCOUNTING", "ADVERTISING", "AGRICULTURAL", "ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES", "CHEMICALS_AND_ALLIED_PRODUCTS", "COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS", "CONSTRUCTION", "CONSULTING_SERVICES", "EDUCATIONAL_SERVICES", "EQUIPMENT_RENTALS_AND_LEASING_SERVICES", "EQUIPMENT_REPAIR_SERVICES", "HIRING_SERVICES", "INDUSTRIAL_AND_MANUFACTURING_SUPPLIES", "MAILING_LISTS", "MARKETING", "MULTILEVEL_MARKETING", "OFFICE_AND_COMMERCIAL_FURNITURE", "OFFICE_SUPPLIES_AND_EQUIPMENT", "PUBLISHING_AND_PRINTING", "QUICK_COPY_AND_REPRODUCTION_SERVICES", "SHIPPING_AND_PACKING", "STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES", "WHOLESALE", "CHILDRENS_CLOTHING", "MENS_CLOTHING", "WOMENS_CLOTHING", "SHOES", "MILITARY_AND_CIVIL_SERVICE_UNIFORMS", "ACCESSORIES", "RETAIL_FINE_JEWELRY_AND_WATCHES", "WHOLESALE_PRECIOUS_STONES_AND_METALS", "FASHION_JEWELLERY", "COMPUTER_AND_DATA_PROCESSING_SERVICES", "DESKTOPS_LAPTOPS_AND_NOTEBOOKS", "COMPUTER_DIGITAL_CONTENT", "ECOMMERCE_SERVICES", "MAINTENANCE_AND_REPAIR_SERVICES", "MONITORS_AND_PROJECTORS", "NETWORKING", "ONLINE_GAMING", "PARTS_AND_ACCESSORIES", "PERIPHERALS", "SOFTWARE", "TRAINING_SERVICES", "WEB_HOSTING_AND_DESIGN", "BUSINESS_AND_SECRETARIAL_SCHOOLS", "CHILD_DAYCARE_SERVICES", "DANCE_HALLS_STUDIOS_AND_SCHOOLS", "VOCATIONAL_AND_TRADE_SCHOOLS", "CAMERAS_CAMCORDERS_AND_EQUIPMENT", "CELL_PHONES_PDAS_AND_PAGERS", "GENERAL_ELECTRONIC_ACCESSORIES", "HOME_AUDIO", "HOME_ELECTRONICS", "SECURITY_AND_SURVEILLANCE", "TELECOMMUNICATION_EQUIPMENT_AND_SALES", "TELECOMMUNICATION_SERVICES", "TELEPHONE_CARDS", "ENTERTAINMENT_MEMORABILIA", "MOVIE_TICKETS", "MOVIES_DVDS_VIDEOTAPES", "MUSIC_CDS_CASSETTES_AND_ALBUMS", "CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO", "CONCERT_TICKETS", "THEATER_TICKETS", "TOYS_AND_GAMES", "ENTERTAINMENT_DIGITAL_CONTENT", "ENTERTAINERS", "ONLINE_GAMES", "VIDEO_GAMES_AND_SYSTEMS", "FINANCIAL_ACCOUNTING", "DEBT_COUNSELING_SERVICE", "FINANCIAL_AND_INVESTMENT_ADVICE", "REAL_ESTATE_AGENT", "RENTAL_PROPERTY_MANAGEMENT", "ALCOHOLIC_BEVERAGES", "CATERING_SERVICES", "COFFEE_AND_TEA", "GOURMET_FOODS", "SPECIALTY_AND_MISCELLANEOUS_FOOD_STORES", "RESTAURANT", "TOBACCO", "VITAMINS_AND_SUPPLEMENTS", "FLORIST", "GIFT_CARD_NOVELTY_AND_SOUVENIR_SHOPS", "GIFTS_GOURMET_FOODS", "NURSERY_PLANTS_AND_FLOWERS", "PARTY_SUPPLIES", "DENTAL_CARE", "MEDICAL_CARE", "MEDICAL_EQUIPMENT_AND_SUPPLIES", "VISION_CARE", "HEALTH_VITAMINS_AND_SUPPLEMENTS", "APPLIANCES", "HOME_ART_DEALERS_AND_GALLERIES", "BED_AND_BATH", "CONSTRUCTION_MATERIAL", "DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY", "EXTERMINATING_AND_DISINFECTING_SERVICES", "FIREPLACE_AND_FIREPLACE_SCREENS", "HOME_FURNITURE", "GARDEN_SUPPLIES", "GLASS_PAINT_AND_WALLPAPER", "HARDWARE_AND_TOOLS", "HOME_DECOR", "HOUSEWARES", "KITCHENWARE", "LANDSCAPING", "RUGS_AND_CARPETS", "SECURITY_AND_SURVEILLANCE_EQUIPMENT", "SWIMMING_POOLS_AND_SPAS", "CHARITY", "POLITICAL", "RELIGIOUS", "OTHER", "PERSONAL", "EDUCATIONAL", "MEDICATION_AND_SUPPLEMENTS", "PET_SHOPS_PET_FOOD_AND_SUPPLIES", "SPECIALTY_OR_RARE_PETS", "VETERINARY_SERVICES", "MEMBERSHIP_SERVICES", "MERCHANDISE", "SERVICES_NOT_ELSEWHERE_CLASSIFIED", "RETAIL_CHEMICALS_AND_ALLIED_PRODUCTS", "DEPARTMENT_STORE", "DISCOUNT_STORE", "DURABLE_GOODS", "NONDURABLE_GOODS", "USED_AND_SECONDHAND_STORE", "VARIETY_STORE", "SERVICES_ADVERTISING", "SHOPPING_SERVICES_AND_BUYING_CLUBS", "CAREER_SERVICES", "CARPENTRY", "CHILD_CARE_SERVICES", "CLEANING_AND_MAINTENANCE", "COMMERCIAL_PHOTOGRAPHY", "SERVICES_COMPUTER_AND_DATA_PROCESSING_SERVICES", "COMPUTER_NETWORK_SERVICES", "SERVICES_CONSULTING_SERVICES", "COUNSELING_SERVICES", "COURIER_SERVICES", "SERVICES_DENTAL_CARE", "SERVICES_ECOMMERCE_SERVICES", "ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR", "ENTERTAINMENT", "EQUIPMENT_RENTAL_AND_LEASING_SERVICES", "EVENT_AND_WEDDING_PLANNING", "GENERAL_CONTRACTORS", "GRAPHIC_AND_COMMERCIAL_DESIGN", "HEALTH_AND_BEAUTY_SPAS", "IDS_LICENSES_AND_PASSPORTS", "IMPORTING_AND_EXPORTING", "INFORMATION_RETRIEVAL_SERVICES", "LANDSCAPING_AND_HORTICULTURAL", "LEGAL_SERVICES_AND_ATTORNEYS", "LOCAL_DELIVERY_SERVICE", "SERVICES_MEDICAL_CARE", "MEMBERSHIP_CLUBS_AND_ORGANIZATIONS", "SERVICES_MISC_PUBLISHING_AND_PRINTING", "MOVING_AND_STORAGE", "PHOTOFINISHING", "PHOTOGRAPHIC_STUDIOS__PORTRAITS", "PROTECTIVE_AND_SECURITY_SERVICES", "SERVICES_QUICK_COPY_AND_REPRODUCTION_SERVICES", "RADIO_TELEVISION_AND_STEREO_REPAIR", "REAL_ESTATE_AGENT_", "SERVICES_RENTAL_PROPERTY_MANAGEMENT", "REUPHOLSTERY_AND_FURNITURE_REPAIR", "SERVICES_SERVICES_NOT_ELSEWHERE_CLASSIFIED", "SERVICES_SHIPPING_AND_PACKING", "SWIMMING_POOL_SERVICES", "TAILORS_AND_ALTERATIONS", "TELECOMMUNICATION_SERVICE", "UTILITIES", "SERVICES_VISION_CARE", "WATCH_CLOCK_AND_JEWELRY_REPAIR", "ATHLETIC_SHOES", "BICYCLE_SHOP_SERVICE_AND_REPAIR", "BOATING_SAILING_AND_ACCESSORIES", "CAMPING_AND_OUTDOORS", "SPORTS_DANCE_HALLS_STUDIOS_AND_SCHOOLS", "EXERCISE_AND_FITNESS", "FAN_GEAR_AND_MEMORABILIA", "HUNTING", "MARTIAL_ARTS_WEAPONS", "SPORT_GAMES_AND_TOYS", "SPORTING_EQUIPMENT", "SPORTS_SWIMMING_POOLS_AND_SPAS", "ARTS_AND_CRAFTS", "HOBBIES_CAMERA_AND_PHOTOGRAPHIC_SUPPLIES", "HOBBY_TOY_AND_GAME_SHOPS", "HOBBIES_MEMORABILIA", "MUSIC_STORE__INSTRUMENTS_AND_SHEET_MUSIC", "HOBBIES_STAMP_AND_COIN", "HOBBIES_STATIONARY_PRINTING_AND_WRITING_PAPER", "HOBBIES_VINTAGE_AND_COLLECTIBLES", "HOBBIES_VIDEO_GAMES_AND_SYSTEMS", "AIRLINE", "AUTO_RENTAL", "BUS_LINE", "CRUISES", "LODGING_AND_ACCOMMODATIONS", "LUGGAGE_AND_LEATHER_GOODS", "RECREATIONAL_SERVICES", "SPORTING_AND_RECREATION_CAMPS", "TAXICABS_AND_LIMOUSINES", "TIMESHARES", "TOURS", "TRAILER_PARKS_OR_CAMPGROUNDS", "TRANSPORTATION_SERVICES__OTHER", "TRAVEL_AGENCY", "NEW_PARTS_AND_SUPPLIES__MOTOR_VEHICLE", "USED_PARTS__MOTOR_VEHICLE", "AUDIO_AND_VIDEO", "AUTO_BODY_REPAIR_AND_PAINT", "SERVICES_AUTO_RENTAL", "AUTO_SERVICE", "AUTOMOTIVE_TIRE_SUPPLY_AND_SERVICE", "BOAT_RENTAL_AND_LEASES", "CAR_WASH", "MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL", "TOOLS_AND_EQUIPMENT", "TOWING_SERVICE", "TRUCK_AND_UTILITY_TRAILER_RENTAL", "VEHICLE_ACCESSORIES", "ARCHITECT_STRUCTURAL_ENGINEER_OR_SURVEYOR", "ACCOUNTANCY_AND_BOOKKEEPING", "BUSINESS_SERVICES", "FINANCIAL_OR_INVESTMENT_ADVICE", "MORTGAGE_BROKERS", "SOFTWARE_AND_IT", "WEBSITE_DEVELOPMENT", "MANAGEMENT_CONSULTANCY", "PROJECT_MANAGEMENT", "MARKETING_ADVERTISING_AND_DESIGN", "GRAPHIC_DESIGN_AND_ILLUSTRATION", "INTERIOR_DESIGN", "RECRUITMENT_AND_HIRING", "LEGAL", "PHOTOGRAPHY", "SECURITY", "PROFESSIONAL_SERVICES_OTHER", "PERSONAL_TRAINER", "SPORTS_COACH", "SPORTS_CLUB", "SPORTS_AND_FITNESS_VENUE", "GYM_OPERATOR", "CLASS_INSTRUCTOR", "EXERCISE_AND_FITNESS_OTHER", "RESTAURANT_OR_CAFE", "TAKEAWAY", "STREET_FOOD_OR_MARKET_STALL", "RETAIL", "WHOLESALING", "SALONS", "AT_HOME_SERVICES", "LICENSED_RETAIL", "LICENSED_FOOD_VENUE", "RETAIL_BARS_AND_RESTAURANTS_OTHER", "DIGITAL_CONTENT_OR_GAMES", "PROMOTION_AND_PUBLISHING", "CATERING", "ENTERTAINERS_AND_DJS", "EVENTS_AND_WEDDINGS", "EVENTS_PRODUCTS", "EVENTS_STAFFING_AND_SERVICES", "TRAVEL_AGENT", "TOUR_GUIDE", "LODGING_AND_ACCOMMODATION", "TV_AND_RADIO", "MUSICIAN_OR_GROUPS", "ENTERTAINMENT_AND_TRAVEL_OTHER", "DOCTOR_NURSE_OR_MIDWIFE", "PHARMACY", "PERSONAL_AND_SOCIAL_CARE", "PHYSIOTHERAPIST", "NUTRITION_AND_DIET", "MENTAL_HEALTH_AND_COUNSELLING", "MEDICAL_EQUIPMENT_AND_SUPPLIERS", "DENTAL", "OPTICIAN", "OTHER_MEDICAL_THERAPY", "CHIROPRACTOR_OR_OSTEOPATH", "PODIATRIST", "COMPLIMENTARY_AND_ALTERNATIVE_MEDICINE", "HEALTH_AND_SOCIAL_CARE_OTHER", "HGV_OR_BUS_OR_COACH_DRIVER", "TAXI_OR_PRIVATE_HIRE_DRIVER", "TRAIN_DRIVER", "OTHER_PROFESSIONAL_DRIVER", "HOME_DELIVERY_AND_COURIER_FIRMS", "HAULAGE_FIRMS", "TAXI_OR_PRIVATE_HIRE_OPERATOR", "MINIBUS_OR_COACH_OPERATOR", "VEHICLE_REPAIR_AND_MAINTENANCE", "NEW_CARS_OR_VEHICLE_SALES", "VEHICLE_RENTAL", "BICYCLE_SHOPS", "USED_CAR_OR_VEHICLE_SALES", "VEHICLE_PARTS", "CAR_WASHING", "TRANSPORT_AND_VEHICLES_OTHER", "CLEANING", "DECORATING", "ELECTRICIAN", "PLUMBER", "GAS_AND_HEATING", "CARPENTRY_TRADE", "ROOFING", "GARDENING_AND_TREE_SURGERY", "GENERAL_CONTRACTOR", "CONSTRUCTION_SUPPLIER", "WASTE_AND_RECYCLING", "SITE_AND_BUILDING_MANAGEMENT", "CONSTRUCTION_TRADES_AND_CLEANING_OTHER", "PROPERTY_OWNER", "PROPERTY_INVESTOR", "PROPERTY_INVESTMENT_FUND", "RESIDENTS_ASSOCIATION", "LEASEHOLD_OR_FREEHOLD", "HOLIDAY_OR_SHORT_TERM_LETS", "PROPERTY_REDEVELOPMENT", "ESTATE_AGENT", "PROPERTY_MANAGEMENT", "STORAGE", "PROPERTY_OTHER", "PERSONAL_TUTOR", "MUSIC_TEACHERS", "PROFESSIONAL_TRAINER", "PUBLIC_SPEAKING", "NURSERY", "CHILDMINDER", "NANNY_OR_AU_PAIR", "CHILDRENS_ACTIVITIES", "STUDENT_RECRUITMENT", "SCHOOLS_COLLEGES_AND_TRAINING", "EDUCATION_AND_SKILLS_OTHER", "ANIMALS", "ARTS_CULTURE_AND_HUMANITIES", "COMMUNITY_DEVELOPMENT", "EDUCATION", "ENVIRONMENT", "HEALTH_AND_DISEASE", "HUMAN_AND_CIVIL_RIGHTS", "CHILDREN_YOUTH_AND_FAMILY", "HOMELESSNESS", "INTERNATIONAL", "RESEARCH_AND_PUBLIC_POLICY", "RELIGION", "NON_PROFIT_OTHER", "MANUFACTURING", "INDUSTRIAL_ENGINEER", "FOOD_OR_DRINK_PRODUCTION", "RESEARCH_AND_DEVELOPMENT", "LIVESTOCK_FARMING", "CROP_FARMING", "HORTICULTURE_OR_PLANT_NURSERY", "FORESTRY", "VETERINARY", "SUPPLIER_TO_AGRICULTURE_OR_INDUSTRY", "EQUESTRIAN", "ANIMAL_CARE", "MANUFACTURING_RND_AND_AGRICULTURE_OTHER" };

        /// <summary>
        /// Converts a BusinessSubCategoryEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BusinessSubCategoryEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BusinessSubCategoryEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BusinessSubCategoryEnum.NOT_PROVIDED:
                case BusinessSubCategoryEnum.ART_AND_CRAFT_SUPPLIES:
                case BusinessSubCategoryEnum.ART_DEALERS_AND_GALLERIES:
                case BusinessSubCategoryEnum.CAMERA_AND_PHOTOGRAPHIC_SUPPLIES:
                case BusinessSubCategoryEnum.DIGITAL_ART:
                case BusinessSubCategoryEnum.MEMORABILIA:
                case BusinessSubCategoryEnum.MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC:
                case BusinessSubCategoryEnum.SEWING_NEEDLEWORK_AND_FABRICS:
                case BusinessSubCategoryEnum.STAMP_AND_COIN:
                case BusinessSubCategoryEnum.STATIONARY_PRINTING_AND_WRITING_PAPER:
                case BusinessSubCategoryEnum.VINTAGE_AND_COLLECTIBLES:
                case BusinessSubCategoryEnum.CLOTHING:
                case BusinessSubCategoryEnum.FURNITURE:
                case BusinessSubCategoryEnum.BABY_PRODUCTS_OTHER:
                case BusinessSubCategoryEnum.SAFETY_AND_HEALTH:
                case BusinessSubCategoryEnum.BATH_AND_BODY:
                case BusinessSubCategoryEnum.FRAGRANCES_AND_PERFUMES:
                case BusinessSubCategoryEnum.MAKEUP_AND_COSMETICS:
                case BusinessSubCategoryEnum.AUDIO_BOOKS:
                case BusinessSubCategoryEnum.DIGITAL_CONTENT:
                case BusinessSubCategoryEnum.EDUCATIONAL_AND_TEXTBOOKS:
                case BusinessSubCategoryEnum.FICTION_AND_NONFICTION:
                case BusinessSubCategoryEnum.MAGAZINES:
                case BusinessSubCategoryEnum.BOOKS_PUBLISHING_AND_PRINTING:
                case BusinessSubCategoryEnum.RARE_AND_USED_BOOKS:
                case BusinessSubCategoryEnum.ACCOUNTING:
                case BusinessSubCategoryEnum.ADVERTISING:
                case BusinessSubCategoryEnum.AGRICULTURAL:
                case BusinessSubCategoryEnum.ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES:
                case BusinessSubCategoryEnum.CHEMICALS_AND_ALLIED_PRODUCTS:
                case BusinessSubCategoryEnum.COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS:
                case BusinessSubCategoryEnum.CONSTRUCTION:
                case BusinessSubCategoryEnum.CONSULTING_SERVICES:
                case BusinessSubCategoryEnum.EDUCATIONAL_SERVICES:
                case BusinessSubCategoryEnum.EQUIPMENT_RENTALS_AND_LEASING_SERVICES:
                case BusinessSubCategoryEnum.EQUIPMENT_REPAIR_SERVICES:
                case BusinessSubCategoryEnum.HIRING_SERVICES:
                case BusinessSubCategoryEnum.INDUSTRIAL_AND_MANUFACTURING_SUPPLIES:
                case BusinessSubCategoryEnum.MAILING_LISTS:
                case BusinessSubCategoryEnum.MARKETING:
                case BusinessSubCategoryEnum.MULTILEVEL_MARKETING:
                case BusinessSubCategoryEnum.OFFICE_AND_COMMERCIAL_FURNITURE:
                case BusinessSubCategoryEnum.OFFICE_SUPPLIES_AND_EQUIPMENT:
                case BusinessSubCategoryEnum.PUBLISHING_AND_PRINTING:
                case BusinessSubCategoryEnum.QUICK_COPY_AND_REPRODUCTION_SERVICES:
                case BusinessSubCategoryEnum.SHIPPING_AND_PACKING:
                case BusinessSubCategoryEnum.STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES:
                case BusinessSubCategoryEnum.WHOLESALE:
                case BusinessSubCategoryEnum.CHILDRENS_CLOTHING:
                case BusinessSubCategoryEnum.MENS_CLOTHING:
                case BusinessSubCategoryEnum.WOMENS_CLOTHING:
                case BusinessSubCategoryEnum.SHOES:
                case BusinessSubCategoryEnum.MILITARY_AND_CIVIL_SERVICE_UNIFORMS:
                case BusinessSubCategoryEnum.ACCESSORIES:
                case BusinessSubCategoryEnum.RETAIL_FINE_JEWELRY_AND_WATCHES:
                case BusinessSubCategoryEnum.WHOLESALE_PRECIOUS_STONES_AND_METALS:
                case BusinessSubCategoryEnum.FASHION_JEWELLERY:
                case BusinessSubCategoryEnum.COMPUTER_AND_DATA_PROCESSING_SERVICES:
                case BusinessSubCategoryEnum.DESKTOPS_LAPTOPS_AND_NOTEBOOKS:
                case BusinessSubCategoryEnum.COMPUTER_DIGITAL_CONTENT:
                case BusinessSubCategoryEnum.ECOMMERCE_SERVICES:
                case BusinessSubCategoryEnum.MAINTENANCE_AND_REPAIR_SERVICES:
                case BusinessSubCategoryEnum.MONITORS_AND_PROJECTORS:
                case BusinessSubCategoryEnum.NETWORKING:
                case BusinessSubCategoryEnum.ONLINE_GAMING:
                case BusinessSubCategoryEnum.PARTS_AND_ACCESSORIES:
                case BusinessSubCategoryEnum.PERIPHERALS:
                case BusinessSubCategoryEnum.SOFTWARE:
                case BusinessSubCategoryEnum.TRAINING_SERVICES:
                case BusinessSubCategoryEnum.WEB_HOSTING_AND_DESIGN:
                case BusinessSubCategoryEnum.BUSINESS_AND_SECRETARIAL_SCHOOLS:
                case BusinessSubCategoryEnum.CHILD_DAYCARE_SERVICES:
                case BusinessSubCategoryEnum.DANCE_HALLS_STUDIOS_AND_SCHOOLS:
                case BusinessSubCategoryEnum.VOCATIONAL_AND_TRADE_SCHOOLS:
                case BusinessSubCategoryEnum.CAMERAS_CAMCORDERS_AND_EQUIPMENT:
                case BusinessSubCategoryEnum.CELL_PHONES_PDAS_AND_PAGERS:
                case BusinessSubCategoryEnum.GENERAL_ELECTRONIC_ACCESSORIES:
                case BusinessSubCategoryEnum.HOME_AUDIO:
                case BusinessSubCategoryEnum.HOME_ELECTRONICS:
                case BusinessSubCategoryEnum.SECURITY_AND_SURVEILLANCE:
                case BusinessSubCategoryEnum.TELECOMMUNICATION_EQUIPMENT_AND_SALES:
                case BusinessSubCategoryEnum.TELECOMMUNICATION_SERVICES:
                case BusinessSubCategoryEnum.TELEPHONE_CARDS:
                case BusinessSubCategoryEnum.ENTERTAINMENT_MEMORABILIA:
                case BusinessSubCategoryEnum.MOVIE_TICKETS:
                case BusinessSubCategoryEnum.MOVIES_DVDS_VIDEOTAPES:
                case BusinessSubCategoryEnum.MUSIC_CDS_CASSETTES_AND_ALBUMS:
                case BusinessSubCategoryEnum.CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO:
                case BusinessSubCategoryEnum.CONCERT_TICKETS:
                case BusinessSubCategoryEnum.THEATER_TICKETS:
                case BusinessSubCategoryEnum.TOYS_AND_GAMES:
                case BusinessSubCategoryEnum.ENTERTAINMENT_DIGITAL_CONTENT:
                case BusinessSubCategoryEnum.ENTERTAINERS:
                case BusinessSubCategoryEnum.ONLINE_GAMES:
                case BusinessSubCategoryEnum.VIDEO_GAMES_AND_SYSTEMS:
                case BusinessSubCategoryEnum.FINANCIAL_ACCOUNTING:
                case BusinessSubCategoryEnum.DEBT_COUNSELING_SERVICE:
                case BusinessSubCategoryEnum.FINANCIAL_AND_INVESTMENT_ADVICE:
                case BusinessSubCategoryEnum.REAL_ESTATE_AGENT:
                case BusinessSubCategoryEnum.RENTAL_PROPERTY_MANAGEMENT:
                case BusinessSubCategoryEnum.ALCOHOLIC_BEVERAGES:
                case BusinessSubCategoryEnum.CATERING_SERVICES:
                case BusinessSubCategoryEnum.COFFEE_AND_TEA:
                case BusinessSubCategoryEnum.GOURMET_FOODS:
                case BusinessSubCategoryEnum.SPECIALTY_AND_MISCELLANEOUS_FOOD_STORES:
                case BusinessSubCategoryEnum.RESTAURANT:
                case BusinessSubCategoryEnum.TOBACCO:
                case BusinessSubCategoryEnum.VITAMINS_AND_SUPPLEMENTS:
                case BusinessSubCategoryEnum.FLORIST:
                case BusinessSubCategoryEnum.GIFT_CARD_NOVELTY_AND_SOUVENIR_SHOPS:
                case BusinessSubCategoryEnum.GIFTS_GOURMET_FOODS:
                case BusinessSubCategoryEnum.NURSERY_PLANTS_AND_FLOWERS:
                case BusinessSubCategoryEnum.PARTY_SUPPLIES:
                case BusinessSubCategoryEnum.DENTAL_CARE:
                case BusinessSubCategoryEnum.MEDICAL_CARE:
                case BusinessSubCategoryEnum.MEDICAL_EQUIPMENT_AND_SUPPLIES:
                case BusinessSubCategoryEnum.VISION_CARE:
                case BusinessSubCategoryEnum.HEALTH_VITAMINS_AND_SUPPLEMENTS:
                case BusinessSubCategoryEnum.APPLIANCES:
                case BusinessSubCategoryEnum.HOME_ART_DEALERS_AND_GALLERIES:
                case BusinessSubCategoryEnum.BED_AND_BATH:
                case BusinessSubCategoryEnum.CONSTRUCTION_MATERIAL:
                case BusinessSubCategoryEnum.DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY:
                case BusinessSubCategoryEnum.EXTERMINATING_AND_DISINFECTING_SERVICES:
                case BusinessSubCategoryEnum.FIREPLACE_AND_FIREPLACE_SCREENS:
                case BusinessSubCategoryEnum.HOME_FURNITURE:
                case BusinessSubCategoryEnum.GARDEN_SUPPLIES:
                case BusinessSubCategoryEnum.GLASS_PAINT_AND_WALLPAPER:
                case BusinessSubCategoryEnum.HARDWARE_AND_TOOLS:
                case BusinessSubCategoryEnum.HOME_DECOR:
                case BusinessSubCategoryEnum.HOUSEWARES:
                case BusinessSubCategoryEnum.KITCHENWARE:
                case BusinessSubCategoryEnum.LANDSCAPING:
                case BusinessSubCategoryEnum.RUGS_AND_CARPETS:
                case BusinessSubCategoryEnum.SECURITY_AND_SURVEILLANCE_EQUIPMENT:
                case BusinessSubCategoryEnum.SWIMMING_POOLS_AND_SPAS:
                case BusinessSubCategoryEnum.CHARITY:
                case BusinessSubCategoryEnum.POLITICAL:
                case BusinessSubCategoryEnum.RELIGIOUS:
                case BusinessSubCategoryEnum.OTHER:
                case BusinessSubCategoryEnum.PERSONAL:
                case BusinessSubCategoryEnum.EDUCATIONAL:
                case BusinessSubCategoryEnum.MEDICATION_AND_SUPPLEMENTS:
                case BusinessSubCategoryEnum.PET_SHOPS_PET_FOOD_AND_SUPPLIES:
                case BusinessSubCategoryEnum.SPECIALTY_OR_RARE_PETS:
                case BusinessSubCategoryEnum.VETERINARY_SERVICES:
                case BusinessSubCategoryEnum.MEMBERSHIP_SERVICES:
                case BusinessSubCategoryEnum.MERCHANDISE:
                case BusinessSubCategoryEnum.SERVICES_NOT_ELSEWHERE_CLASSIFIED:
                case BusinessSubCategoryEnum.RETAIL_CHEMICALS_AND_ALLIED_PRODUCTS:
                case BusinessSubCategoryEnum.DEPARTMENT_STORE:
                case BusinessSubCategoryEnum.DISCOUNT_STORE:
                case BusinessSubCategoryEnum.DURABLE_GOODS:
                case BusinessSubCategoryEnum.NONDURABLE_GOODS:
                case BusinessSubCategoryEnum.USED_AND_SECONDHAND_STORE:
                case BusinessSubCategoryEnum.VARIETY_STORE:
                case BusinessSubCategoryEnum.SERVICES_ADVERTISING:
                case BusinessSubCategoryEnum.SHOPPING_SERVICES_AND_BUYING_CLUBS:
                case BusinessSubCategoryEnum.CAREER_SERVICES:
                case BusinessSubCategoryEnum.CARPENTRY:
                case BusinessSubCategoryEnum.CHILD_CARE_SERVICES:
                case BusinessSubCategoryEnum.CLEANING_AND_MAINTENANCE:
                case BusinessSubCategoryEnum.COMMERCIAL_PHOTOGRAPHY:
                case BusinessSubCategoryEnum.SERVICES_COMPUTER_AND_DATA_PROCESSING_SERVICES:
                case BusinessSubCategoryEnum.COMPUTER_NETWORK_SERVICES:
                case BusinessSubCategoryEnum.SERVICES_CONSULTING_SERVICES:
                case BusinessSubCategoryEnum.COUNSELING_SERVICES:
                case BusinessSubCategoryEnum.COURIER_SERVICES:
                case BusinessSubCategoryEnum.SERVICES_DENTAL_CARE:
                case BusinessSubCategoryEnum.SERVICES_ECOMMERCE_SERVICES:
                case BusinessSubCategoryEnum.ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR:
                case BusinessSubCategoryEnum.ENTERTAINMENT:
                case BusinessSubCategoryEnum.EQUIPMENT_RENTAL_AND_LEASING_SERVICES:
                case BusinessSubCategoryEnum.EVENT_AND_WEDDING_PLANNING:
                case BusinessSubCategoryEnum.GENERAL_CONTRACTORS:
                case BusinessSubCategoryEnum.GRAPHIC_AND_COMMERCIAL_DESIGN:
                case BusinessSubCategoryEnum.HEALTH_AND_BEAUTY_SPAS:
                case BusinessSubCategoryEnum.IDS_LICENSES_AND_PASSPORTS:
                case BusinessSubCategoryEnum.IMPORTING_AND_EXPORTING:
                case BusinessSubCategoryEnum.INFORMATION_RETRIEVAL_SERVICES:
                case BusinessSubCategoryEnum.LANDSCAPING_AND_HORTICULTURAL:
                case BusinessSubCategoryEnum.LEGAL_SERVICES_AND_ATTORNEYS:
                case BusinessSubCategoryEnum.LOCAL_DELIVERY_SERVICE:
                case BusinessSubCategoryEnum.SERVICES_MEDICAL_CARE:
                case BusinessSubCategoryEnum.MEMBERSHIP_CLUBS_AND_ORGANIZATIONS:
                case BusinessSubCategoryEnum.SERVICES_MISC_PUBLISHING_AND_PRINTING:
                case BusinessSubCategoryEnum.MOVING_AND_STORAGE:
                case BusinessSubCategoryEnum.PHOTOFINISHING:
                case BusinessSubCategoryEnum.PHOTOGRAPHIC_STUDIOS__PORTRAITS:
                case BusinessSubCategoryEnum.PROTECTIVE_AND_SECURITY_SERVICES:
                case BusinessSubCategoryEnum.SERVICES_QUICK_COPY_AND_REPRODUCTION_SERVICES:
                case BusinessSubCategoryEnum.RADIO_TELEVISION_AND_STEREO_REPAIR:
                case BusinessSubCategoryEnum.REAL_ESTATE_AGENT_1:
                case BusinessSubCategoryEnum.SERVICES_RENTAL_PROPERTY_MANAGEMENT:
                case BusinessSubCategoryEnum.REUPHOLSTERY_AND_FURNITURE_REPAIR:
                case BusinessSubCategoryEnum.SERVICES_SERVICES_NOT_ELSEWHERE_CLASSIFIED:
                case BusinessSubCategoryEnum.SERVICES_SHIPPING_AND_PACKING:
                case BusinessSubCategoryEnum.SWIMMING_POOL_SERVICES:
                case BusinessSubCategoryEnum.TAILORS_AND_ALTERATIONS:
                case BusinessSubCategoryEnum.TELECOMMUNICATION_SERVICE:
                case BusinessSubCategoryEnum.UTILITIES:
                case BusinessSubCategoryEnum.SERVICES_VISION_CARE:
                case BusinessSubCategoryEnum.WATCH_CLOCK_AND_JEWELRY_REPAIR:
                case BusinessSubCategoryEnum.ATHLETIC_SHOES:
                case BusinessSubCategoryEnum.BICYCLE_SHOP_SERVICE_AND_REPAIR:
                case BusinessSubCategoryEnum.BOATING_SAILING_AND_ACCESSORIES:
                case BusinessSubCategoryEnum.CAMPING_AND_OUTDOORS:
                case BusinessSubCategoryEnum.SPORTS_DANCE_HALLS_STUDIOS_AND_SCHOOLS:
                case BusinessSubCategoryEnum.EXERCISE_AND_FITNESS:
                case BusinessSubCategoryEnum.FAN_GEAR_AND_MEMORABILIA:
                case BusinessSubCategoryEnum.HUNTING:
                case BusinessSubCategoryEnum.MARTIAL_ARTS_WEAPONS:
                case BusinessSubCategoryEnum.SPORT_GAMES_AND_TOYS:
                case BusinessSubCategoryEnum.SPORTING_EQUIPMENT:
                case BusinessSubCategoryEnum.SPORTS_SWIMMING_POOLS_AND_SPAS:
                case BusinessSubCategoryEnum.ARTS_AND_CRAFTS:
                case BusinessSubCategoryEnum.HOBBIES_CAMERA_AND_PHOTOGRAPHIC_SUPPLIES:
                case BusinessSubCategoryEnum.HOBBY_TOY_AND_GAME_SHOPS:
                case BusinessSubCategoryEnum.HOBBIES_MEMORABILIA:
                case BusinessSubCategoryEnum.MUSIC_STORE__INSTRUMENTS_AND_SHEET_MUSIC1:
                case BusinessSubCategoryEnum.HOBBIES_STAMP_AND_COIN:
                case BusinessSubCategoryEnum.HOBBIES_STATIONARY_PRINTING_AND_WRITING_PAPER:
                case BusinessSubCategoryEnum.HOBBIES_VINTAGE_AND_COLLECTIBLES:
                case BusinessSubCategoryEnum.HOBBIES_VIDEO_GAMES_AND_SYSTEMS:
                case BusinessSubCategoryEnum.AIRLINE:
                case BusinessSubCategoryEnum.AUTO_RENTAL:
                case BusinessSubCategoryEnum.BUS_LINE:
                case BusinessSubCategoryEnum.CRUISES:
                case BusinessSubCategoryEnum.LODGING_AND_ACCOMMODATIONS:
                case BusinessSubCategoryEnum.LUGGAGE_AND_LEATHER_GOODS:
                case BusinessSubCategoryEnum.RECREATIONAL_SERVICES:
                case BusinessSubCategoryEnum.SPORTING_AND_RECREATION_CAMPS:
                case BusinessSubCategoryEnum.TAXICABS_AND_LIMOUSINES:
                case BusinessSubCategoryEnum.TIMESHARES:
                case BusinessSubCategoryEnum.TOURS:
                case BusinessSubCategoryEnum.TRAILER_PARKS_OR_CAMPGROUNDS:
                case BusinessSubCategoryEnum.TRANSPORTATION_SERVICES__OTHER:
                case BusinessSubCategoryEnum.TRAVEL_AGENCY:
                case BusinessSubCategoryEnum.NEW_PARTS_AND_SUPPLIES__MOTOR_VEHICLE:
                case BusinessSubCategoryEnum.USED_PARTS__MOTOR_VEHICLE:
                case BusinessSubCategoryEnum.AUDIO_AND_VIDEO:
                case BusinessSubCategoryEnum.AUTO_BODY_REPAIR_AND_PAINT:
                case BusinessSubCategoryEnum.SERVICES_AUTO_RENTAL:
                case BusinessSubCategoryEnum.AUTO_SERVICE:
                case BusinessSubCategoryEnum.AUTOMOTIVE_TIRE_SUPPLY_AND_SERVICE:
                case BusinessSubCategoryEnum.BOAT_RENTAL_AND_LEASES:
                case BusinessSubCategoryEnum.CAR_WASH:
                case BusinessSubCategoryEnum.MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL:
                case BusinessSubCategoryEnum.TOOLS_AND_EQUIPMENT:
                case BusinessSubCategoryEnum.TOWING_SERVICE:
                case BusinessSubCategoryEnum.TRUCK_AND_UTILITY_TRAILER_RENTAL:
                case BusinessSubCategoryEnum.VEHICLE_ACCESSORIES:
                case BusinessSubCategoryEnum.ARCHITECT_STRUCTURAL_ENGINEER_OR_SURVEYOR:
                case BusinessSubCategoryEnum.ACCOUNTANCY_AND_BOOKKEEPING:
                case BusinessSubCategoryEnum.BUSINESS_SERVICES:
                case BusinessSubCategoryEnum.FINANCIAL_OR_INVESTMENT_ADVICE:
                case BusinessSubCategoryEnum.MORTGAGE_BROKERS:
                case BusinessSubCategoryEnum.SOFTWARE_AND_IT:
                case BusinessSubCategoryEnum.WEBSITE_DEVELOPMENT:
                case BusinessSubCategoryEnum.MANAGEMENT_CONSULTANCY:
                case BusinessSubCategoryEnum.PROJECT_MANAGEMENT:
                case BusinessSubCategoryEnum.MARKETING_ADVERTISING_AND_DESIGN:
                case BusinessSubCategoryEnum.GRAPHIC_DESIGN_AND_ILLUSTRATION:
                case BusinessSubCategoryEnum.INTERIOR_DESIGN:
                case BusinessSubCategoryEnum.RECRUITMENT_AND_HIRING:
                case BusinessSubCategoryEnum.LEGAL:
                case BusinessSubCategoryEnum.PHOTOGRAPHY:
                case BusinessSubCategoryEnum.SECURITY:
                case BusinessSubCategoryEnum.PROFESSIONAL_SERVICES_OTHER:
                case BusinessSubCategoryEnum.PERSONAL_TRAINER:
                case BusinessSubCategoryEnum.SPORTS_COACH:
                case BusinessSubCategoryEnum.SPORTS_CLUB:
                case BusinessSubCategoryEnum.SPORTS_AND_FITNESS_VENUE:
                case BusinessSubCategoryEnum.GYM_OPERATOR:
                case BusinessSubCategoryEnum.CLASS_INSTRUCTOR:
                case BusinessSubCategoryEnum.EXERCISE_AND_FITNESS_OTHER:
                case BusinessSubCategoryEnum.RESTAURANT_OR_CAFE:
                case BusinessSubCategoryEnum.TAKEAWAY:
                case BusinessSubCategoryEnum.STREET_FOOD_OR_MARKET_STALL:
                case BusinessSubCategoryEnum.RETAIL:
                case BusinessSubCategoryEnum.WHOLESALING:
                case BusinessSubCategoryEnum.SALONS:
                case BusinessSubCategoryEnum.AT_HOME_SERVICES:
                case BusinessSubCategoryEnum.LICENSED_RETAIL:
                case BusinessSubCategoryEnum.LICENSED_FOOD_VENUE:
                case BusinessSubCategoryEnum.RETAIL_BARS_AND_RESTAURANTS_OTHER:
                case BusinessSubCategoryEnum.DIGITAL_CONTENT_OR_GAMES:
                case BusinessSubCategoryEnum.PROMOTION_AND_PUBLISHING:
                case BusinessSubCategoryEnum.CATERING:
                case BusinessSubCategoryEnum.ENTERTAINERS_AND_DJS:
                case BusinessSubCategoryEnum.EVENTS_AND_WEDDINGS:
                case BusinessSubCategoryEnum.EVENTS_PRODUCTS:
                case BusinessSubCategoryEnum.EVENTS_STAFFING_AND_SERVICES:
                case BusinessSubCategoryEnum.TRAVEL_AGENT:
                case BusinessSubCategoryEnum.TOUR_GUIDE:
                case BusinessSubCategoryEnum.LODGING_AND_ACCOMMODATION:
                case BusinessSubCategoryEnum.TV_AND_RADIO:
                case BusinessSubCategoryEnum.MUSICIAN_OR_GROUPS:
                case BusinessSubCategoryEnum.ENTERTAINMENT_AND_TRAVEL_OTHER:
                case BusinessSubCategoryEnum.DOCTOR_NURSE_OR_MIDWIFE:
                case BusinessSubCategoryEnum.PHARMACY:
                case BusinessSubCategoryEnum.PERSONAL_AND_SOCIAL_CARE:
                case BusinessSubCategoryEnum.PHYSIOTHERAPIST:
                case BusinessSubCategoryEnum.NUTRITION_AND_DIET:
                case BusinessSubCategoryEnum.MENTAL_HEALTH_AND_COUNSELLING:
                case BusinessSubCategoryEnum.MEDICAL_EQUIPMENT_AND_SUPPLIERS:
                case BusinessSubCategoryEnum.DENTAL:
                case BusinessSubCategoryEnum.OPTICIAN:
                case BusinessSubCategoryEnum.OTHER_MEDICAL_THERAPY:
                case BusinessSubCategoryEnum.CHIROPRACTOR_OR_OSTEOPATH:
                case BusinessSubCategoryEnum.PODIATRIST:
                case BusinessSubCategoryEnum.COMPLIMENTARY_AND_ALTERNATIVE_MEDICINE:
                case BusinessSubCategoryEnum.HEALTH_AND_SOCIAL_CARE_OTHER:
                case BusinessSubCategoryEnum.HGV_OR_BUS_OR_COACH_DRIVER:
                case BusinessSubCategoryEnum.TAXI_OR_PRIVATE_HIRE_DRIVER:
                case BusinessSubCategoryEnum.TRAIN_DRIVER:
                case BusinessSubCategoryEnum.OTHER_PROFESSIONAL_DRIVER:
                case BusinessSubCategoryEnum.HOME_DELIVERY_AND_COURIER_FIRMS:
                case BusinessSubCategoryEnum.HAULAGE_FIRMS:
                case BusinessSubCategoryEnum.TAXI_OR_PRIVATE_HIRE_OPERATOR:
                case BusinessSubCategoryEnum.MINIBUS_OR_COACH_OPERATOR:
                case BusinessSubCategoryEnum.VEHICLE_REPAIR_AND_MAINTENANCE:
                case BusinessSubCategoryEnum.NEW_CARS_OR_VEHICLE_SALES:
                case BusinessSubCategoryEnum.VEHICLE_RENTAL:
                case BusinessSubCategoryEnum.BICYCLE_SHOPS:
                case BusinessSubCategoryEnum.USED_CAR_OR_VEHICLE_SALES:
                case BusinessSubCategoryEnum.VEHICLE_PARTS:
                case BusinessSubCategoryEnum.CAR_WASHING:
                case BusinessSubCategoryEnum.TRANSPORT_AND_VEHICLES_OTHER:
                case BusinessSubCategoryEnum.CLEANING:
                case BusinessSubCategoryEnum.DECORATING:
                case BusinessSubCategoryEnum.ELECTRICIAN:
                case BusinessSubCategoryEnum.PLUMBER:
                case BusinessSubCategoryEnum.GAS_AND_HEATING:
                case BusinessSubCategoryEnum.CARPENTRY_TRADE:
                case BusinessSubCategoryEnum.ROOFING:
                case BusinessSubCategoryEnum.GARDENING_AND_TREE_SURGERY:
                case BusinessSubCategoryEnum.GENERAL_CONTRACTOR:
                case BusinessSubCategoryEnum.CONSTRUCTION_SUPPLIER:
                case BusinessSubCategoryEnum.WASTE_AND_RECYCLING:
                case BusinessSubCategoryEnum.SITE_AND_BUILDING_MANAGEMENT:
                case BusinessSubCategoryEnum.CONSTRUCTION_TRADES_AND_CLEANING_OTHER:
                case BusinessSubCategoryEnum.PROPERTY_OWNER:
                case BusinessSubCategoryEnum.PROPERTY_INVESTOR:
                case BusinessSubCategoryEnum.PROPERTY_INVESTMENT_FUND:
                case BusinessSubCategoryEnum.RESIDENTS_ASSOCIATION:
                case BusinessSubCategoryEnum.LEASEHOLD_OR_FREEHOLD:
                case BusinessSubCategoryEnum.HOLIDAY_OR_SHORT_TERM_LETS:
                case BusinessSubCategoryEnum.PROPERTY_REDEVELOPMENT:
                case BusinessSubCategoryEnum.ESTATE_AGENT:
                case BusinessSubCategoryEnum.PROPERTY_MANAGEMENT:
                case BusinessSubCategoryEnum.STORAGE:
                case BusinessSubCategoryEnum.PROPERTY_OTHER:
                case BusinessSubCategoryEnum.PERSONAL_TUTOR:
                case BusinessSubCategoryEnum.MUSIC_TEACHERS:
                case BusinessSubCategoryEnum.PROFESSIONAL_TRAINER:
                case BusinessSubCategoryEnum.PUBLIC_SPEAKING:
                case BusinessSubCategoryEnum.NURSERY:
                case BusinessSubCategoryEnum.CHILDMINDER:
                case BusinessSubCategoryEnum.NANNY_OR_AU_PAIR:
                case BusinessSubCategoryEnum.CHILDRENS_ACTIVITIES:
                case BusinessSubCategoryEnum.STUDENT_RECRUITMENT:
                case BusinessSubCategoryEnum.SCHOOLS_COLLEGES_AND_TRAINING:
                case BusinessSubCategoryEnum.EDUCATION_AND_SKILLS_OTHER:
                case BusinessSubCategoryEnum.ANIMALS:
                case BusinessSubCategoryEnum.ARTS_CULTURE_AND_HUMANITIES:
                case BusinessSubCategoryEnum.COMMUNITY_DEVELOPMENT:
                case BusinessSubCategoryEnum.EDUCATION:
                case BusinessSubCategoryEnum.ENVIRONMENT:
                case BusinessSubCategoryEnum.HEALTH_AND_DISEASE:
                case BusinessSubCategoryEnum.HUMAN_AND_CIVIL_RIGHTS:
                case BusinessSubCategoryEnum.CHILDREN_YOUTH_AND_FAMILY:
                case BusinessSubCategoryEnum.HOMELESSNESS:
                case BusinessSubCategoryEnum.INTERNATIONAL:
                case BusinessSubCategoryEnum.RESEARCH_AND_PUBLIC_POLICY:
                case BusinessSubCategoryEnum.RELIGION:
                case BusinessSubCategoryEnum.NON_PROFIT_OTHER:
                case BusinessSubCategoryEnum.MANUFACTURING:
                case BusinessSubCategoryEnum.INDUSTRIAL_ENGINEER:
                case BusinessSubCategoryEnum.FOOD_OR_DRINK_PRODUCTION:
                case BusinessSubCategoryEnum.RESEARCH_AND_DEVELOPMENT:
                case BusinessSubCategoryEnum.LIVESTOCK_FARMING:
                case BusinessSubCategoryEnum.CROP_FARMING:
                case BusinessSubCategoryEnum.HORTICULTURE_OR_PLANT_NURSERY:
                case BusinessSubCategoryEnum.FORESTRY:
                case BusinessSubCategoryEnum.VETERINARY:
                case BusinessSubCategoryEnum.SUPPLIER_TO_AGRICULTURE_OR_INDUSTRY:
                case BusinessSubCategoryEnum.EQUESTRIAN:
                case BusinessSubCategoryEnum.ANIMAL_CARE:
                case BusinessSubCategoryEnum.MANUFACTURING_RND_AND_AGRICULTURE_OTHER:
                    return StringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BusinessSubCategoryEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BusinessSubCategoryEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BusinessSubCategoryEnum> enumValues)
        {
            return enumValues?.Select(ToValue).ToList();
        }

        /// <summary>
        /// Converts a string value into BusinessSubCategoryEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BusinessSubCategoryEnum value</returns>
        public static BusinessSubCategoryEnum ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BusinessSubCategoryEnum");

            return (BusinessSubCategoryEnum) index;
        }
    }
} 