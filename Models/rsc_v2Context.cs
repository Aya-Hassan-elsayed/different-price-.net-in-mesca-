using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Zezoprice.Models
{
    public partial class rsc_v2Context : DbContext
    {
        public rsc_v2Context()
        {
        }

        public rsc_v2Context(DbContextOptions<rsc_v2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AddressesUpdated> AddressesUpdateds { get; set; } = null!;
        public virtual DbSet<AdjustmentCommpanyComment> AdjustmentCommpanyComments { get; set; } = null!;
        public virtual DbSet<AdjustmentsReviewMsdComment> AdjustmentsReviewMsdComments { get; set; } = null!;
        public virtual DbSet<AfterExtractionStatus> AfterExtractionStatuses { get; set; } = null!;
        public virtual DbSet<Areatype> Areatypes { get; set; } = null!;
        public virtual DbSet<Aspnetuser> Aspnetusers { get; set; } = null!;
        public virtual DbSet<AssCount> AssCounts { get; set; } = null!;
        public virtual DbSet<Assignement> Assignements { get; set; } = null!;
        public virtual DbSet<AssignmentsRequestsView> AssignmentsRequestsViews { get; set; } = null!;
        public virtual DbSet<AssignmentsRequestsViewDash> AssignmentsRequestsViewDashes { get; set; } = null!;
        public virtual DbSet<Attributeproperty> Attributeproperties { get; set; } = null!;
        public virtual DbSet<AuthGroup> AuthGroups { get; set; } = null!;
        public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; } = null!;
        public virtual DbSet<AuthPermission> AuthPermissions { get; set; } = null!;
        public virtual DbSet<AuthUser> AuthUsers { get; set; } = null!;
        public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; } = null!;
        public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; } = null!;
        public virtual DbSet<AutoAssignementsShahin> AutoAssignementsShahins { get; set; } = null!;
        public virtual DbSet<CallcenterComment> CallcenterComments { get; set; } = null!;
        public virtual DbSet<CallcenterComplaint> CallcenterComplaints { get; set; } = null!;
        public virtual DbSet<CallcenterView> CallcenterViews { get; set; } = null!;
        public virtual DbSet<CertificateCover> CertificateCovers { get; set; } = null!;
        public virtual DbSet<CertificateCoverV2> CertificateCoverV2s { get; set; } = null!;
        public virtual DbSet<CertificateView> CertificateViews { get; set; } = null!;
        public virtual DbSet<CertificateViewDash> CertificateViewDashes { get; set; } = null!;
        public virtual DbSet<CertificateViewLayout> CertificateViewLayouts { get; set; } = null!;
        public virtual DbSet<CertificateViewLayout3857> CertificateViewLayout3857s { get; set; } = null!;
        public virtual DbSet<CertificateViewLayoutEdit> CertificateViewLayoutEdits { get; set; } = null!;
        public virtual DbSet<CertificateViewLayoutEdit2> CertificateViewLayoutEdit2s { get; set; } = null!;
        public virtual DbSet<CertificateViewQgi> CertificateViewQgis { get; set; } = null!;
        public virtual DbSet<CollectingView> CollectingViews { get; set; } = null!;
        public virtual DbSet<CompaniesZone> CompaniesZones { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyGov> CompanyGovs { get; set; } = null!;
        public virtual DbSet<Complain> Complains { get; set; } = null!;
        public virtual DbSet<ComplainsNew> ComplainsNews { get; set; } = null!;
        public virtual DbSet<ComplainsReplay> ComplainsReplays { get; set; } = null!;
        public virtual DbSet<ComplaintLukup> ComplaintLukups { get; set; } = null!;
        public virtual DbSet<Countrequestpricedifference> Countrequestpricedifferences { get; set; } = null!;
        public virtual DbSet<Countshippingorder> Countshippingorders { get; set; } = null!;
        public virtual DbSet<CurrentDistrict> CurrentDistricts { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; } = null!;
        public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; } = null!;
        public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; } = null!;
        public virtual DbSet<DjangoSession> DjangoSessions { get; set; } = null!;
        public virtual DbSet<EditAddressesUpdated> EditAddressesUpdateds { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<ErroDecumentation> ErroDecumentations { get; set; } = null!;
        public virtual DbSet<ExrtacopiesEditStatus> ExrtacopiesEditStatuses { get; set; } = null!;
        public virtual DbSet<ExrtacopiesPrintStatus> ExrtacopiesPrintStatuses { get; set; } = null!;
        public virtual DbSet<ExrtacopiesType> ExrtacopiesTypes { get; set; } = null!;
        public virtual DbSet<FieldDataReviewV2> FieldDataReviewV2s { get; set; } = null!;
        public virtual DbSet<FieldDataV2> FieldDataV2s { get; set; } = null!;
        public virtual DbSet<FieldDataViewV2> FieldDataViewV2s { get; set; } = null!;
        public virtual DbSet<FieldViewA> FieldViewAs { get; set; } = null!;
        public virtual DbSet<Fieldlookup> Fieldlookups { get; set; } = null!;
        public virtual DbSet<FinancialViewList> FinancialViewLists { get; set; } = null!;
        public virtual DbSet<FloorName> FloorNames { get; set; } = null!;
        public virtual DbSet<Galiastable> Galiastables { get; set; } = null!;
        public virtual DbSet<Gcoordsystem> Gcoordsystems { get; set; } = null!;
        public virtual DbSet<Geometryproperty> Geometryproperties { get; set; } = null!;
        public virtual DbSet<Gfeature> Gfeatures { get; set; } = null!;
        public virtual DbSet<Gfeaturesbase> Gfeaturesbases { get; set; } = null!;
        public virtual DbSet<Gov3857> Gov3857s { get; set; } = null!;
        public virtual DbSet<GovReqCount> GovReqCounts { get; set; } = null!;
        public virtual DbSet<Governorate> Governorates { get; set; } = null!;
        public virtual DbSet<Gparameter> Gparameters { get; set; } = null!;
        public virtual DbSet<Gpicklisttable> Gpicklisttables { get; set; } = null!;
        public virtual DbSet<Gsqloperatortable> Gsqloperatortables { get; set; } = null!;
        public virtual DbSet<InquiryreqeustsUpdated> InquiryreqeustsUpdateds { get; set; } = null!;
        public virtual DbSet<InquiryreqeustsView> InquiryreqeustsViews { get; set; } = null!;
        public virtual DbSet<Inquiryrequest> Inquiryrequests { get; set; } = null!;
        public virtual DbSet<Issue> Issues { get; set; } = null!;
        public virtual DbSet<Librarytable> Librarytables { get; set; } = null!;
        public virtual DbSet<LkupRefuseReason> LkupRefuseReasons { get; set; } = null!;
        public virtual DbSet<LkupUnittype> LkupUnittypes { get; set; } = null!;
        public virtual DbSet<LukpTransactionType> LukpTransactionTypes { get; set; } = null!;
        public virtual DbSet<MappUser> MappUsers { get; set; } = null!;
        public virtual DbSet<MappUserRole> MappUserRoles { get; set; } = null!;
        public virtual DbSet<Modificationlog> Modificationlogs { get; set; } = null!;
        public virtual DbSet<Modifiedtable> Modifiedtables { get; set; } = null!;
        public virtual DbSet<Nezar> Nezars { get; set; } = null!;
        public virtual DbSet<Nezar2> Nezar2s { get; set; } = null!;
        public virtual DbSet<Nezar3> Nezar3s { get; set; } = null!;
        public virtual DbSet<Nsdi> Nsdis { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<Orderstatus> Orderstatuses { get; set; } = null!;
        public virtual DbSet<Paymenttrasnsaction> Paymenttrasnsactions { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestPrice> RequestPrices { get; set; } = null!;
        public virtual DbSet<RequestTawheed> RequestTawheeds { get; set; } = null!;
        public virtual DbSet<RequestTrip> RequestTrips { get; set; } = null!;
        public virtual DbSet<Requestpricedifference> Requestpricedifferences { get; set; } = null!;
        public virtual DbSet<RequestsExtrainfo> RequestsExtrainfos { get; set; } = null!;
        public virtual DbSet<RequestsOverlap> RequestsOverlaps { get; set; } = null!;
        public virtual DbSet<RequestsOverlapNcpslu> RequestsOverlapNcpslus { get; set; } = null!;
        public virtual DbSet<Requeststatus> Requeststatuses { get; set; } = null!;
        public virtual DbSet<Sec3857> Sec3857s { get; set; } = null!;
        public virtual DbSet<SeragTewheed> SeragTewheeds { get; set; } = null!;
        public virtual DbSet<ShippingView> ShippingViews { get; set; } = null!;
        public virtual DbSet<Shippingorder> Shippingorders { get; set; } = null!;
        public virtual DbSet<ShippingordersNotpaid> ShippingordersNotpaids { get; set; } = null!;
        public virtual DbSet<ShippingordersStatus> ShippingordersStatuses { get; set; } = null!;
        public virtual DbSet<Shippingtype> Shippingtypes { get; set; } = null!;
        public virtual DbSet<Statistic> Statistics { get; set; } = null!;
        public virtual DbSet<Subunittype> Subunittypes { get; set; } = null!;
        public virtual DbSet<SurveyReviewComment> SurveyReviewComments { get; set; } = null!;
        public virtual DbSet<SurveyReviewMsdComment> SurveyReviewMsdComments { get; set; } = null!;
        public virtual DbSet<Surveygi> Surveygis { get; set; } = null!;
        public virtual DbSet<SurveygisView> SurveygisViews { get; set; } = null!;
        public virtual DbSet<SurveygisView2> SurveygisView2s { get; set; } = null!;
        public virtual DbSet<Surveyteam> Surveyteams { get; set; } = null!;
        public virtual DbSet<SurveyteamComment> SurveyteamComments { get; set; } = null!;
        public virtual DbSet<SurveyteamListView> SurveyteamListViews { get; set; } = null!;
        public virtual DbSet<SurveyteamRegion> SurveyteamRegions { get; set; } = null!;
        public virtual DbSet<SurveyteamViewCollected> SurveyteamViewCollecteds { get; set; } = null!;
        public virtual DbSet<SurveyteamsView> SurveyteamsViews { get; set; } = null!;
        public virtual DbSet<Ta3delatComm> Ta3delatComms { get; set; } = null!;
        public virtual DbSet<Techoffice> Techoffices { get; set; } = null!;
        public virtual DbSet<UnittypeValue> UnittypeValues { get; set; } = null!;
        public virtual DbSet<UsageStatus> UsageStatuses { get; set; } = null!;
        public virtual DbSet<UserLog> UserLogs { get; set; } = null!;
        public virtual DbSet<Useraddress> Useraddresses { get; set; } = null!;
        public virtual DbSet<Userprofile> Userprofiles { get; set; } = null!;
        public virtual DbSet<ValidationGehat> ValidationGehats { get; set; } = null!;
        public virtual DbSet<ValidationProfile> ValidationProfiles { get; set; } = null!;
        public virtual DbSet<ValidationRole> ValidationRoles { get; set; } = null!;
        public virtual DbSet<Zdifferencespricandtype> Zdifferencespricandtypes { get; set; } = null!;
        public virtual DbSet<ZpayShahin> ZpayShahins { get; set; } = null!;
        public virtual DbSet<Zshippingorder> Zshippingorders { get; set; } = null!;
        public virtual DbSet<ZshippingordersCount> ZshippingordersCounts { get; set; } = null!;
        public virtual DbSet<ZshippingordersCountSum> ZshippingordersCountSums { get; set; } = null!;

        // Unable to generate entity type for table 'gdo.gfieldmapping' since its primary key could not be scaffolded. Please see the warning messages.
        // Unable to generate entity type for table 'gdo.gindexcolumns' since its primary key could not be scaffolded. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("host=81.21.104.178;port=5432;user name = zezo;password= Ah123456*;database =rsc_v2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("postgis")
                .HasPostgresExtension("postgres_fdw")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("topology", "postgis_topology");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("addresses");

                entity.HasIndex(e => e.Districtid, "add_district");

                entity.HasIndex(e => e.Regionid, "add_regionid");

                entity.HasIndex(e => e.Requestid, "add_requestid");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.Easternborder)
                    .HasColumnType("character varying")
                    .HasColumnName("easternborder");

                entity.Property(e => e.Easternborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("easternborderlength");

                entity.Property(e => e.FloorNumber).HasColumnName("floor_number");

                entity.Property(e => e.Floornumbertext)
                    .HasColumnType("character varying")
                    .HasColumnName("floornumbertext");

                entity.Property(e => e.Maritimeborder)
                    .HasColumnType("character varying")
                    .HasColumnName("maritimeborder");

                entity.Property(e => e.Maritimeborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("maritimeborderlength");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Partnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("partnumber");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Sinknumber)
                    .HasColumnType("character varying")
                    .HasColumnName("sinknumber");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Tribalborder)
                    .HasColumnType("character varying")
                    .HasColumnName("tribalborder");

                entity.Property(e => e.Tribalborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("tribalborderlength");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Westernborder)
                    .HasColumnType("character varying")
                    .HasColumnName("westernborder");

                entity.Property(e => e.Westernborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("westernborderlength");
            });

            modelBuilder.Entity<AddressesUpdated>(entity =>
            {
                entity.ToTable("addresses_updated");

                entity.HasIndex(e => e.Districtid, "add_up_district");

                entity.HasIndex(e => e.Regionid, "add_up_region");

                entity.HasIndex(e => e.Requestid, "add_up_requestid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.Easternborder)
                    .HasColumnType("character varying")
                    .HasColumnName("easternborder");

                entity.Property(e => e.Easternborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("easternborderlength");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Floornumbertext)
                    .HasColumnType("character varying")
                    .HasColumnName("floornumbertext");

                entity.Property(e => e.Maritimeborder)
                    .HasColumnType("character varying")
                    .HasColumnName("maritimeborder");

                entity.Property(e => e.Maritimeborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("maritimeborderlength");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Partnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("partnumber");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Sinknumber)
                    .HasColumnType("character varying")
                    .HasColumnName("sinknumber");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Tribalborder)
                    .HasColumnType("character varying")
                    .HasColumnName("tribalborder");

                entity.Property(e => e.Tribalborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("tribalborderlength");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Westernborder)
                    .HasColumnType("character varying")
                    .HasColumnName("westernborder");

                entity.Property(e => e.Westernborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("westernborderlength");
            });

            modelBuilder.Entity<AdjustmentCommpanyComment>(entity =>
            {
                entity.ToTable("adjustment_commpany_comments");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('adjustment_commpany_comments'::regclass)");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sender).HasColumnName("sender");

                entity.Property(e => e.UserName)
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<AdjustmentsReviewMsdComment>(entity =>
            {
                entity.ToTable("adjustments_review_msd_comments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime).HasColumnName("comment_time");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sender).HasColumnName("sender");

                entity.Property(e => e.UserName)
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<AfterExtractionStatus>(entity =>
            {
                entity.ToTable("after_extraction_status");

                entity.HasIndex(e => e.Id, "ex_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Areatype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("areatype");

                entity.HasIndex(e => e.Areatype1, "areatype_index")
                    .IsUnique();

                entity.Property(e => e.Areatype1)
                    .HasMaxLength(10)
                    .HasColumnName("areatype");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Aspnetuser>(entity =>
            {
                entity.ToTable("aspnetusers");

                entity.HasIndex(e => e.Addressid, "IX_AspNetUsers_AddressId");

                entity.HasIndex(e => e.Id, "aspnetusers_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Addressid).HasColumnName("addressid");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(15)
                    .HasColumnName("phonenumber");
            });

            modelBuilder.Entity<AssCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ass_count");

                entity.Property(e => e.Numberoftasks).HasColumnName("numberoftasks");

                entity.Property(e => e.Taskstatus).HasColumnName("taskstatus");

                entity.Property(e => e.Teamid).HasColumnName("teamid");
            });

            modelBuilder.Entity<Assignement>(entity =>
            {
                entity.ToTable("assignements");

                entity.HasIndex(e => e.Requestnumber, "ass_requestnumber")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "assignements_id_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptedDate).HasColumnName("accepted_date");

                entity.Property(e => e.Assigned).HasColumnName("assigned");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.CallcenterConfirmTime).HasColumnName("callcenter_confirm_time");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected)
                    .HasColumnName("collected")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Com)
                    .HasColumnType("character varying")
                    .HasColumnName("com");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Confirmed)
                    .HasColumnName("confirmed")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CretRecievedMsd).HasColumnName("cret_recieved_msd");

                entity.Property(e => e.DifferenceAreaStatus).HasColumnName("difference_area_status");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Featuretype).HasColumnName("featuretype");

                entity.Property(e => e.FinDate).HasColumnName("fin_date");

                entity.Property(e => e.Finabstract).HasColumnName("finabstract");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.LogProc).HasColumnName("log_proc");

                entity.Property(e => e.LogTime).HasColumnName("log_time");

                entity.Property(e => e.LogUser).HasColumnName("log_user");

                entity.Property(e => e.Oldsubunit).HasColumnName("oldsubunit");

                entity.Property(e => e.Oldunittype).HasColumnName("oldunittype");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus)
                    .HasColumnName("print_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Processtype).HasColumnName("processtype");

                entity.Property(e => e.RefuseReason).HasColumnName("refuse_reason");

                entity.Property(e => e.Repeatrefuse)
                    .HasColumnName("repeatrefuse")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(21)
                    .HasColumnName("requestnumber");

                entity.Property(e => e.ReviewAfterExtraction).HasColumnName("review_after_extraction");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragLetters)
                    .HasMaxLength(1)
                    .HasColumnName("serag_letters");

                entity.Property(e => e.Session)
                    .HasColumnType("character varying")
                    .HasColumnName("session");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewMsd).HasColumnName("survey_review_msd");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Tawheed)
                    .HasColumnName("tawheed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");
            });

            modelBuilder.Entity<AssignmentsRequestsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("assignments_requests_view");

                entity.Property(e => e.AcceptedDate).HasColumnName("accepted_date");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AreaFCategory).HasColumnName("area_f_category");

                entity.Property(e => e.AreaMCategory).HasColumnName("area_m_category");

                entity.Property(e => e.AreaSCategory).HasColumnName("area_s_category");

                entity.Property(e => e.Areatype).HasColumnName("areatype");

                entity.Property(e => e.Areatypetext).HasColumnName("areatypetext");

                entity.Property(e => e.AssignStatus).HasColumnName("assign_status");

                entity.Property(e => e.AssignTeamStatus).HasColumnName("assign_team_status");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.AttachLayout)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_layout");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Certt).HasColumnName("certt");

                entity.Property(e => e.Certtt).HasColumnName("certtt");

                entity.Property(e => e.CollectStatus).HasColumnName("collect_status");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovCode).HasColumnName("gov_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PriceEstimated).HasColumnName("price_estimated");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.RefuseReason)
                    .HasMaxLength(100)
                    .HasColumnName("refuse_reason");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Secid).HasColumnName("secid");

                entity.Property(e => e.SendReview).HasColumnName("send_review");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.SubunittypeArabicname)
                    .HasMaxLength(50)
                    .HasColumnName("subunittype_arabicname");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Telephonenumber).HasColumnName("telephonenumber");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");
            });

            modelBuilder.Entity<AssignmentsRequestsViewDash>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("assignments_requests_view_dash");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AreaFCategory).HasColumnName("area_f_category");

                entity.Property(e => e.AreaMCategory).HasColumnName("area_m_category");

                entity.Property(e => e.AreaSCategory).HasColumnName("area_s_category");

                entity.Property(e => e.AssignStatus).HasColumnName("assign_status");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovCode).HasColumnName("gov_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PriceComp).HasColumnName("price_comp");

                entity.Property(e => e.PriceEdge).HasColumnName("price_edge");

                entity.Property(e => e.PriceEstimated).HasColumnName("price_estimated");

                entity.Property(e => e.PriceMsd).HasColumnName("price_msd");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Telephonenumber).HasColumnName("telephonenumber");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");
            });

            modelBuilder.Entity<Attributeproperty>(entity =>
            {
                entity.HasKey(e => e.Indexid)
                    .HasName("attributeproperties_pkey");

                entity.ToTable("attributeproperties", "gdo");

                entity.Property(e => e.Indexid)
                    .ValueGeneratedNever()
                    .HasColumnName("indexid");

                entity.Property(e => e.Fielddescription)
                    .HasMaxLength(255)
                    .HasColumnName("fielddescription");

                entity.Property(e => e.Fieldformat)
                    .HasMaxLength(255)
                    .HasColumnName("fieldformat");

                entity.Property(e => e.Fieldprecision).HasColumnName("fieldprecision");

                entity.Property(e => e.Fieldtype).HasColumnName("fieldtype");

                entity.Property(e => e.Isfielddisplayable).HasColumnName("isfielddisplayable");

                entity.Property(e => e.Iskeyfield).HasColumnName("iskeyfield");
            });

            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group");

                entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "auth_group_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AuthGroupPermission>(entity =>
            {
                entity.ToTable("auth_group_permissions");

                entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission");

                entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codename)
                    .HasMaxLength(100)
                    .HasColumnName("codename");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AuthPermissions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.ToTable("auth_user");

                entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Username, "auth_user_username_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateJoined).HasColumnName("date_joined");

                entity.Property(e => e.Email)
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(150)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.LastName)
                    .HasMaxLength(150)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(128)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AuthUserGroup>(entity =>
            {
                entity.ToTable("auth_user_groups");

                entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

                entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthUserUserPermission>(entity =>
            {
                entity.ToTable("auth_user_user_permissions");

                entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
            });

            modelBuilder.Entity<AutoAssignementsShahin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("auto_assignements_shahin");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovId).HasColumnName("gov_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");
            });

            modelBuilder.Entity<CallcenterComment>(entity =>
            {
                entity.ToTable("callcenter_comments");

                entity.HasIndex(e => e.Requestnumber, "requestnumber");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");
            });

            modelBuilder.Entity<CallcenterComplaint>(entity =>
            {
                entity.ToTable("callcenter_complaint");

                entity.HasIndex(e => e.Requestnumber, "requestnumber_complaint");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Complaint).HasColumnName("complaint");

                entity.Property(e => e.ComplaintStatus).HasColumnName("complaint_status");

                entity.Property(e => e.ComplaintTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("complaint_time");

                entity.Property(e => e.ComplaintType).HasColumnName("complaint_type");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(21)
                    .HasColumnName("requestnumber");
            });

            modelBuilder.Entity<CallcenterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("callcenter_view");

                entity.Property(e => e.Adress)
                    .HasColumnType("character varying")
                    .HasColumnName("adress");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.CallcenterConfirmTime).HasColumnName("callcenter_confirm_time");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Complaint).HasColumnName("complaint");

                entity.Property(e => e.ComplaintTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("complaint_time");

                entity.Property(e => e.ComplaintType).HasColumnName("complaint_type");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LogTime).HasColumnName("log_time");

                entity.Property(e => e.LogUser).HasColumnName("log_user");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.RefuseReason)
                    .HasMaxLength(100)
                    .HasColumnName("refuse_reason");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.RequestStatus).HasColumnName("request_status");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Session)
                    .HasColumnType("character varying")
                    .HasColumnName("session");

                entity.Property(e => e.Shippingdate).HasColumnName("shippingdate");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Telephonenumber).HasColumnName("telephonenumber");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");
            });

            modelBuilder.Entity<CertificateCover>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_cover");

                entity.Property(e => e.Addr)
                    .HasColumnType("character varying")
                    .HasColumnName("addr");

                entity.Property(e => e.Areaafter).HasColumnName("areaafter");

                entity.Property(e => e.Areabefore).HasColumnName("areabefore");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Garden).HasColumnName("garden");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaintypeCsv).HasColumnName("maintype_csv");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Shippingtype).HasColumnName("shippingtype");

                entity.Property(e => e.Ssec)
                    .HasColumnType("character varying")
                    .HasColumnName("ssec");

                entity.Property(e => e.SubtypeCsv).HasColumnName("subtype_csv");

                entity.Property(e => e.Subunittypebefore).HasColumnName("subunittypebefore");

                entity.Property(e => e.Typeafter).HasColumnName("typeafter");

                entity.Property(e => e.Typebefore)
                    .HasColumnType("character varying")
                    .HasColumnName("typebefore");
            });

            modelBuilder.Entity<CertificateCoverV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_cover_v2");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.DiffPrice).HasColumnName("diff_price");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.NewAreaApartment).HasColumnName("new_area_apartment");

                entity.Property(e => e.NewAreabuilding).HasColumnName("new_areabuilding");

                entity.Property(e => e.NewArealand).HasColumnName("new_arealand");

                entity.Property(e => e.NewUnittype).HasColumnName("new_unittype");

                entity.Property(e => e.NewUsage).HasColumnName("new_usage");

                entity.Property(e => e.OldArea).HasColumnName("old_area");

                entity.Property(e => e.OldAreatype).HasColumnName("old_areatype");

                entity.Property(e => e.OldBuildingarea)
                    .HasColumnType("character varying")
                    .HasColumnName("old_buildingarea");

                entity.Property(e => e.OldLandarea)
                    .HasColumnType("character varying")
                    .HasColumnName("old_landarea");

                entity.Property(e => e.OldPrice).HasColumnName("old_price");

                entity.Property(e => e.OldSubunittype).HasColumnName("old_subunittype");

                entity.Property(e => e.OldSubunittypearea).HasColumnName("old_subunittypearea");

                entity.Property(e => e.OldUnittype).HasColumnName("old_unittype");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.SecName)
                    .HasMaxLength(200)
                    .HasColumnName("sec_name");

                entity.Property(e => e.SsecName)
                    .HasMaxLength(200)
                    .HasColumnName("ssec_name");

                entity.Property(e => e.Telephonenumber)
                    .HasColumnType("character varying")
                    .HasColumnName("telephonenumber");

                entity.Property(e => e.Telephonenumber2)
                    .HasColumnType("character varying")
                    .HasColumnName("telephonenumber2");

                entity.Property(e => e.TotalPrice).HasColumnName("total_price");
            });

            modelBuilder.Entity<CertificateView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_view");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.ApartNum)
                    .HasColumnType("character varying")
                    .HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaBuild).HasColumnName("area_build");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.Comcode).HasColumnName("comcode");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.Descrip).HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB)
                    .HasColumnType("character varying")
                    .HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.Elevator).HasColumnName("elevator");

                entity.Property(e => e.FloorNT)
                    .HasColumnType("character varying")
                    .HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb)
                    .HasMaxLength(20)
                    .HasColumnName("floor_numb");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Hod)
                    .HasColumnType("character varying")
                    .HasColumnName("hod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3a)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.NorthB)
                    .HasColumnType("character varying")
                    .HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.PropertyN)
                    .HasColumnType("character varying")
                    .HasColumnName("property_n");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SouthB)
                    .HasColumnType("character varying")
                    .HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.Surveynum)
                    .HasMaxLength(10)
                    .HasColumnName("surveynum");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestB)
                    .HasColumnType("character varying")
                    .HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<CertificateViewDash>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_view_dash");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.ApartNum)
                    .HasColumnType("character varying")
                    .HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaBuild).HasColumnName("area_build");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.Comcode).HasColumnName("comcode");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.Descrip).HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB)
                    .HasColumnType("character varying")
                    .HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.Elevator).HasColumnName("elevator");

                entity.Property(e => e.FloorNT)
                    .HasColumnType("character varying")
                    .HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb)
                    .HasMaxLength(20)
                    .HasColumnName("floor_numb");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Hod)
                    .HasColumnType("character varying")
                    .HasColumnName("hod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3a)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.Mar).HasColumnName("mar");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.NorthB)
                    .HasColumnType("character varying")
                    .HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.Oldunittype).HasColumnName("oldunittype");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.PropertyN)
                    .HasColumnType("character varying")
                    .HasColumnName("property_n");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SouthB)
                    .HasColumnType("character varying")
                    .HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.Surveynum)
                    .HasMaxLength(10)
                    .HasColumnName("surveynum");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestB)
                    .HasColumnType("character varying")
                    .HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<CertificateViewLayout>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_view_layout");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.ApartNum)
                    .HasColumnType("character varying")
                    .HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaBuild).HasColumnName("area_build");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.DateShahr).HasColumnName("date_shahr");

                entity.Property(e => e.DateTasgel).HasColumnName("date_tasgel");

                entity.Property(e => e.Descrip).HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB)
                    .HasColumnType("character varying")
                    .HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.FloorNT)
                    .HasColumnType("character varying")
                    .HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb)
                    .HasMaxLength(20)
                    .HasColumnName("floor_numb");

                entity.Property(e => e.Garden).HasColumnName("garden");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovNo)
                    .HasMaxLength(200)
                    .HasColumnName("gov_no");

                entity.Property(e => e.Hod)
                    .HasColumnType("character varying")
                    .HasColumnName("hod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3a)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a");

                entity.Property(e => e.Letter)
                    .HasMaxLength(1)
                    .HasColumnName("letter");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.MilOverlap).HasColumnName("mil_overlap");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Ncpslu).HasColumnName("ncpslu");

                entity.Property(e => e.NcpsluOverlap).HasColumnName("ncpslu_overlap");

                entity.Property(e => e.NorthB)
                    .HasColumnType("character varying")
                    .HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Print).HasColumnName("print");

                entity.Property(e => e.Printdate).HasColumnName("printdate");

                entity.Property(e => e.PropertyN)
                    .HasColumnType("character varying")
                    .HasColumnName("property_n");

                entity.Property(e => e.Receiptimagepath).HasColumnName("receiptimagepath");

                entity.Property(e => e.RegistrationNo)
                    .HasColumnType("character varying")
                    .HasColumnName("registration_no");

                entity.Property(e => e.RequestNo)
                    .HasColumnType("character varying")
                    .HasColumnName("request_no");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sealmm).HasColumnName("sealmm");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SecNow)
                    .HasMaxLength(200)
                    .HasColumnName("sec_now");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragShaqaa).HasColumnName("serag_shaqaa");

                entity.Property(e => e.Seragid).HasColumnName("seragid");

                entity.Property(e => e.SeragidCount).HasColumnName("seragid_count");

                entity.Property(e => e.ShaqaaSeragCount).HasColumnName("shaqaa_serag_count");

                entity.Property(e => e.SouthB)
                    .HasColumnType("character varying")
                    .HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.SsecNow)
                    .HasColumnType("character varying")
                    .HasColumnName("ssec_now");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Surveynum)
                    .HasMaxLength(10)
                    .HasColumnName("surveynum");

                entity.Property(e => e.Tawheed).HasColumnName("tawheed");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.Validdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("validdate");

                entity.Property(e => e.Validuser)
                    .HasMaxLength(50)
                    .HasColumnName("validuser");

                entity.Property(e => e.WestB)
                    .HasColumnType("character varying")
                    .HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");

                entity.Property(e => e.X)
                    .HasColumnType("character varying")
                    .HasColumnName("x");

                entity.Property(e => e.Y)
                    .HasColumnType("character varying")
                    .HasColumnName("y");
            });

            modelBuilder.Entity<CertificateViewLayout3857>(entity =>
            {
                entity.HasKey(e => e.Id0)
                    .HasName("certificate_view_layout_3857_pkey");

                entity.ToTable("certificate_view_layout_3857");

                entity.Property(e => e.Id0).HasColumnName("id_0");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.ApartNum)
                    .HasColumnType("character varying")
                    .HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaBuild).HasColumnName("area_build");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Descrip)
                    .HasColumnType("character varying")
                    .HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB)
                    .HasColumnType("character varying")
                    .HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.FloorNT)
                    .HasColumnType("character varying")
                    .HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb)
                    .HasMaxLength(20)
                    .HasColumnName("floor_numb");

                entity.Property(e => e.Garden).HasColumnName("garden");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovNo)
                    .HasMaxLength(200)
                    .HasColumnName("gov_no");

                entity.Property(e => e.Hod)
                    .HasColumnType("character varying")
                    .HasColumnName("hod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3a)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a");

                entity.Property(e => e.Letter)
                    .HasMaxLength(1)
                    .HasColumnName("letter");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Ncpslu)
                    .HasColumnType("character varying")
                    .HasColumnName("ncpslu");

                entity.Property(e => e.NorthB)
                    .HasColumnType("character varying")
                    .HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.Overlap)
                    .HasColumnType("character varying")
                    .HasColumnName("overlap");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Print)
                    .HasColumnType("character varying")
                    .HasColumnName("print");

                entity.Property(e => e.Printdate)
                    .HasColumnType("character varying")
                    .HasColumnName("printdate");

                entity.Property(e => e.PropertyN)
                    .HasColumnType("character varying")
                    .HasColumnName("property_n");

                entity.Property(e => e.Receiptimagepath)
                    .HasColumnType("character varying")
                    .HasColumnName("receiptimagepath");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sealmm).HasColumnName("sealmm");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SecNow)
                    .HasMaxLength(200)
                    .HasColumnName("sec_now");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragShaqaa)
                    .HasColumnType("character varying")
                    .HasColumnName("serag_shaqaa");

                entity.Property(e => e.Seragid)
                    .HasColumnType("character varying")
                    .HasColumnName("seragid");

                entity.Property(e => e.SeragidCount).HasColumnName("seragid_count");

                entity.Property(e => e.ShaqaaSeragCount).HasColumnName("shaqaa_serag_count");

                entity.Property(e => e.SouthB)
                    .HasColumnType("character varying")
                    .HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.SsecNow)
                    .HasColumnType("character varying")
                    .HasColumnName("ssec_now");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Surveynum)
                    .HasMaxLength(10)
                    .HasColumnName("surveynum");

                entity.Property(e => e.Tawheed).HasColumnName("tawheed");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestB)
                    .HasColumnType("character varying")
                    .HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");

                entity.Property(e => e.X)
                    .HasColumnType("character varying")
                    .HasColumnName("x");

                entity.Property(e => e.Y)
                    .HasColumnType("character varying")
                    .HasColumnName("y");
            });

            modelBuilder.Entity<CertificateViewLayoutEdit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_view_layout_edit");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.ApartNum)
                    .HasColumnType("character varying")
                    .HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaBuild).HasColumnName("area_build");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Descrip).HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB)
                    .HasColumnType("character varying")
                    .HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.FloorNT)
                    .HasColumnType("character varying")
                    .HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb)
                    .HasMaxLength(20)
                    .HasColumnName("floor_numb");

                entity.Property(e => e.Garden).HasColumnName("garden");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Hod)
                    .HasColumnType("character varying")
                    .HasColumnName("hod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3a)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Ncpslu).HasColumnName("ncpslu");

                entity.Property(e => e.NorthB)
                    .HasColumnType("character varying")
                    .HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Print).HasColumnName("print");

                entity.Property(e => e.Printdate).HasColumnName("printdate");

                entity.Property(e => e.PropertyN)
                    .HasColumnType("character varying")
                    .HasColumnName("property_n");

                entity.Property(e => e.Receiptimagepath).HasColumnName("receiptimagepath");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sealmm).HasColumnName("sealmm");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragShaqaa).HasColumnName("serag_shaqaa");

                entity.Property(e => e.Seragid).HasColumnName("seragid");

                entity.Property(e => e.SeragidCount).HasColumnName("seragid_count");

                entity.Property(e => e.ShaqaaSeragCount).HasColumnName("shaqaa_serag_count");

                entity.Property(e => e.SouthB)
                    .HasColumnType("character varying")
                    .HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Surveynum)
                    .HasMaxLength(10)
                    .HasColumnName("surveynum");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestB)
                    .HasColumnType("character varying")
                    .HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");

                entity.Property(e => e.X)
                    .HasColumnType("character varying")
                    .HasColumnName("x");

                entity.Property(e => e.Y)
                    .HasColumnType("character varying")
                    .HasColumnName("y");
            });

            modelBuilder.Entity<CertificateViewLayoutEdit2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("certificate_view_layout_edit2");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.ApartNum)
                    .HasColumnType("character varying")
                    .HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaBuild).HasColumnName("area_build");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Descrip).HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB)
                    .HasColumnType("character varying")
                    .HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.FloorNT)
                    .HasColumnType("character varying")
                    .HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb)
                    .HasMaxLength(20)
                    .HasColumnName("floor_numb");

                entity.Property(e => e.Garden).HasColumnName("garden");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Hod)
                    .HasColumnType("character varying")
                    .HasColumnName("hod");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3a)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Ncpslu).HasColumnName("ncpslu");

                entity.Property(e => e.NorthB)
                    .HasColumnType("character varying")
                    .HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Print).HasColumnName("print");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.Printdate).HasColumnName("printdate");

                entity.Property(e => e.PropertyN)
                    .HasColumnType("character varying")
                    .HasColumnName("property_n");

                entity.Property(e => e.Receiptimagepath).HasColumnName("receiptimagepath");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sealmm).HasColumnName("sealmm");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragShaqaa).HasColumnName("serag_shaqaa");

                entity.Property(e => e.Seragid).HasColumnName("seragid");

                entity.Property(e => e.SeragidCount).HasColumnName("seragid_count");

                entity.Property(e => e.ShaqaaSeragCount).HasColumnName("shaqaa_serag_count");

                entity.Property(e => e.SouthB)
                    .HasColumnType("character varying")
                    .HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Surveynum)
                    .HasMaxLength(10)
                    .HasColumnName("surveynum");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestB)
                    .HasColumnType("character varying")
                    .HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");

                entity.Property(e => e.X)
                    .HasColumnType("character varying")
                    .HasColumnName("x");

                entity.Property(e => e.Y)
                    .HasColumnType("character varying")
                    .HasColumnName("y");
            });

            modelBuilder.Entity<CertificateViewQgi>(entity =>
            {
                entity.ToTable("certificate_view_qgis");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ApartNum).HasColumnName("apart_num");

                entity.Property(e => e.AreaAp1).HasColumnName("area_ap1");

                entity.Property(e => e.AreaAp2).HasColumnName("area_ap2");

                entity.Property(e => e.AreaAp3).HasColumnName("area_ap3");

                entity.Property(e => e.AreaAp4).HasColumnName("area_ap4");

                entity.Property(e => e.AreaAp5).HasColumnName("area_ap5");

                entity.Property(e => e.AreaAp6).HasColumnName("area_ap6");

                entity.Property(e => e.AreaLand).HasColumnName("area_land");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.DateShahr).HasColumnName("date_shahr");

                entity.Property(e => e.DateTasgel).HasColumnName("date_tasgel");

                entity.Property(e => e.Descrip).HasColumnName("descrip");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastB).HasColumnName("east_b");

                entity.Property(e => e.EastL).HasColumnName("east_l");

                entity.Property(e => e.EastL1).HasColumnName("east_l1");

                entity.Property(e => e.EastL2).HasColumnName("east_l2");

                entity.Property(e => e.EastL3).HasColumnName("east_l3");

                entity.Property(e => e.EastL4).HasColumnName("east_l4");

                entity.Property(e => e.EastL5).HasColumnName("east_l5");

                entity.Property(e => e.EastL6).HasColumnName("east_l6");

                entity.Property(e => e.FloorNT).HasColumnName("floor_n_t");

                entity.Property(e => e.FloorNumb).HasColumnName("floor_numb");

                entity.Property(e => e.Garden).HasColumnName("garden");

                entity.Property(e => e.Geom).HasColumnName("geom");

                entity.Property(e => e.Gov).HasColumnName("gov");

                entity.Property(e => e.Hod).HasColumnName("hod");

                entity.Property(e => e.Ket3a).HasColumnName("ket3a");

                entity.Property(e => e.Manwr).HasColumnName("manwr");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NorthB).HasColumnName("north_b");

                entity.Property(e => e.NorthL).HasColumnName("north_l");

                entity.Property(e => e.NorthL1).HasColumnName("north_l1");

                entity.Property(e => e.NorthL2).HasColumnName("north_l2");

                entity.Property(e => e.NorthL3).HasColumnName("north_l3");

                entity.Property(e => e.NorthL4).HasColumnName("north_l4");

                entity.Property(e => e.NorthL5).HasColumnName("north_l5");

                entity.Property(e => e.NorthL6).HasColumnName("north_l6");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Printdate).HasColumnName("printdate");

                entity.Property(e => e.RegistrationNo).HasColumnName("registration_no");

                entity.Property(e => e.ReqStatus).HasColumnName("req_status");

                entity.Property(e => e.RequestNo).HasColumnName("request_no");

                entity.Property(e => e.Requestnumber).HasColumnName("requestnumber");

                entity.Property(e => e.Sealm).HasColumnName("sealm");

                entity.Property(e => e.Sec).HasColumnName("sec");

                entity.Property(e => e.SeragShaqaa).HasColumnName("serag_shaqaa");

                entity.Property(e => e.Seragid).HasColumnName("seragid");

                entity.Property(e => e.SouthB).HasColumnName("south_b");

                entity.Property(e => e.SouthL).HasColumnName("south_l");

                entity.Property(e => e.SouthL1).HasColumnName("south_l1");

                entity.Property(e => e.SouthL2).HasColumnName("south_l2");

                entity.Property(e => e.SouthL3).HasColumnName("south_l3");

                entity.Property(e => e.SouthL4).HasColumnName("south_l4");

                entity.Property(e => e.SouthL5).HasColumnName("south_l5");

                entity.Property(e => e.SouthL6).HasColumnName("south_l6");

                entity.Property(e => e.Ssec).HasColumnName("ssec");

                entity.Property(e => e.Streetname).HasColumnName("streetname");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Surveyid).HasColumnName("surveyid");

                entity.Property(e => e.Surveynum).HasColumnName("surveynum");

                entity.Property(e => e.Totalaparts).HasColumnName("totalaparts");

                entity.Property(e => e.Totalarea).HasColumnName("totalarea");

                entity.Property(e => e.Unittype).HasColumnName("unittype");

                entity.Property(e => e.Usage).HasColumnName("usage");

                entity.Property(e => e.ValidDate).HasColumnName("valid_date");

                entity.Property(e => e.ValidUser).HasColumnName("valid_user");

                entity.Property(e => e.WestB).HasColumnName("west_b");

                entity.Property(e => e.WestL).HasColumnName("west_l");

                entity.Property(e => e.WestL1).HasColumnName("west_l1");

                entity.Property(e => e.WestL2).HasColumnName("west_l2");

                entity.Property(e => e.WestL3).HasColumnName("west_l3");

                entity.Property(e => e.WestL4).HasColumnName("west_l4");

                entity.Property(e => e.WestL5).HasColumnName("west_l5");

                entity.Property(e => e.WestL6).HasColumnName("west_l6");

                entity.Property(e => e.XValidation).HasColumnName("x_validation");

                entity.Property(e => e.YValidation).HasColumnName("y_validation");
            });

            modelBuilder.Entity<CollectingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("collecting_view");

                entity.Property(e => e.AcceptedRequest).HasColumnName("accepted_request");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.CannotUploadedCert).HasColumnName("cannot_uploaded_cert");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.ComType).HasColumnName("com_type");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.DeleveringCert).HasColumnName("delevering_cert");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NotUploadedCert).HasColumnName("not_uploaded_cert");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PriceComp).HasColumnName("price_comp");

                entity.Property(e => e.PriceCompReceivable).HasColumnName("price_comp_receivable");

                entity.Property(e => e.PriceEdge).HasColumnName("price_edge");

                entity.Property(e => e.PriceEdgeReceivable).HasColumnName("price_edge_receivable");

                entity.Property(e => e.PriceMsd).HasColumnName("price_msd");

                entity.Property(e => e.PriceMsdReceivable).HasColumnName("price_msd_receivable");

                entity.Property(e => e.PriceReceivable).HasColumnName("price_receivable");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.ReviewRequest).HasColumnName("review_request");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Totaaaaaaaaaaaaaaaal).HasColumnName("totaaaaaaaaaaaaaaaal");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");

                entity.Property(e => e.UploadedCert).HasColumnName("uploaded_cert");
            });

            modelBuilder.Entity<CompaniesZone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("companies_zones");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovId).HasColumnName("gov_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("companies");

                entity.HasIndex(e => e.Id, "companies_index")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.BankAcc).HasColumnName("bank_acc");

                entity.Property(e => e.ComType).HasColumnName("com_type");

                entity.Property(e => e.CommercialRecord).HasColumnName("commercial_record");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fax).HasColumnName("fax");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.PmName).HasColumnName("pm_name");

                entity.Property(e => e.Userid)
                    .HasColumnType("character varying")
                    .HasColumnName("userid");

                entity.Property(e => e.UsernameId).HasColumnName("username_id");
            });

            modelBuilder.Entity<CompanyGov>(entity =>
            {
                entity.ToTable("company_gov");

                entity.HasIndex(e => e.Regionid, "regionid_gov")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.GovId).HasColumnName("gov_id");

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<Complain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("complains");

                entity.Property(e => e.NewComplain).HasColumnName("new_complain");

                entity.Property(e => e.NewComplainAddeddate).HasColumnName("new_complain_addeddate");

                entity.Property(e => e.NewComplainId).HasColumnName("new_complain_id");

                entity.Property(e => e.NewComplainPhone)
                    .HasMaxLength(200)
                    .HasColumnName("new_complain_phone");

                entity.Property(e => e.NewComplainType)
                    .HasMaxLength(200)
                    .HasColumnName("new_complain_type");

                entity.Property(e => e.ReplayDate).HasColumnName("replay_date");

                entity.Property(e => e.ReplayId).HasColumnName("replay_id");

                entity.Property(e => e.ReplayText).HasColumnName("replay_text");

                entity.Property(e => e.ReplayUserId).HasColumnName("replay_user_id");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(200)
                    .HasColumnName("requestnumber");
            });

            modelBuilder.Entity<ComplainsNew>(entity =>
            {
                entity.ToTable("complains_new");

                entity.HasIndex(e => e.ProblemUser, "validation_complains_new_problem_user_id_a087d6b8");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.Complaint).HasColumnName("complaint");

                entity.Property(e => e.Complainttype)
                    .HasMaxLength(200)
                    .HasColumnName("complainttype");

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .HasColumnName("phone");

                entity.Property(e => e.ProblemUser).HasColumnName("problem_user");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(200)
                    .HasColumnName("requestnumber");

                entity.HasOne(d => d.ProblemUserNavigation)
                    .WithMany(p => p.ComplainsNews)
                    .HasForeignKey(d => d.ProblemUser)
                    .HasConstraintName("validation_complains_problem_user_21fb2955_fk_validatio");
            });

            modelBuilder.Entity<ComplainsReplay>(entity =>
            {
                entity.ToTable("complains_replay");

                entity.HasIndex(e => e.ComplainsId, "complains_replay_complains_id_bda8b686");

                entity.HasIndex(e => e.ReplayUser, "validation_complains_replay_replay_user_id_ee391892");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComplainsId).HasColumnName("complains_id");

                entity.Property(e => e.Complaintreply).HasColumnName("complaintreply");

                entity.Property(e => e.Datereply).HasColumnName("datereply");

                entity.Property(e => e.ReplayUser).HasColumnName("replay_user");

                entity.HasOne(d => d.Complains)
                    .WithMany(p => p.ComplainsReplays)
                    .HasForeignKey(d => d.ComplainsId)
                    .HasConstraintName("validation_complains_replay_complains_id_2ddc8e5a_fk");

                entity.HasOne(d => d.ReplayUserNavigation)
                    .WithMany(p => p.ComplainsReplays)
                    .HasForeignKey(d => d.ReplayUser)
                    .HasConstraintName("validation_complains_replay_user_85c467c3_fk_validatio");
            });

            modelBuilder.Entity<ComplaintLukup>(entity =>
            {
                entity.ToTable("complaint_lukup");

                entity.HasIndex(e => e.Id, "complaint_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Complaint).HasColumnName("complaint");
            });

            modelBuilder.Entity<Countrequestpricedifference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("countrequestpricedifferences");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Countrequestpricedifferences).HasColumnName("countrequestpricedifferences");
            });

            modelBuilder.Entity<Countshippingorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("countshippingorders");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Countshippingorders).HasColumnName("countshippingorders");
            });

            modelBuilder.Entity<CurrentDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("current_districts");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.SecCode)
                    .HasColumnType("character varying")
                    .HasColumnName("sec_code");

                entity.Property(e => e.SsecCode)
                    .HasColumnType("character varying")
                    .HasColumnName("ssec_code");

                entity.Property(e => e.SsecNameAr)
                    .HasColumnType("character varying")
                    .HasColumnName("ssec_name_ar");

                entity.Property(e => e.SsecNameEn)
                    .HasColumnType("character varying")
                    .HasColumnName("ssec_name_en");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("districts");

                entity.HasIndex(e => e.Arabicname, "dis_arabicname");

                entity.HasIndex(e => e.Id, "districtsid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasMaxLength(255)
                    .HasColumnName("addeddate")
                    .IsFixedLength();

                entity.Property(e => e.Arabicname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicname");

                entity.Property(e => e.Englishname)
                    .HasMaxLength(200)
                    .HasColumnName("englishname");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .HasColumnName("latitude")
                    .IsFixedLength();

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .HasColumnName("longitude")
                    .IsFixedLength();

                entity.Property(e => e.Modifieddate)
                    .HasMaxLength(255)
                    .HasColumnName("modifieddate")
                    .IsFixedLength();

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<DjangoAdminLog>(entity =>
            {
                entity.ToTable("django_admin_log");

                entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

                entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFlag).HasColumnName("action_flag");

                entity.Property(e => e.ActionTime).HasColumnName("action_time");

                entity.Property(e => e.ChangeMessage).HasColumnName("change_message");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectRepr)
                    .HasMaxLength(200)
                    .HasColumnName("object_repr");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoContentType>(entity =>
            {
                entity.ToTable("django_content_type");

                entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLabel)
                    .HasMaxLength(100)
                    .HasColumnName("app_label");

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<DjangoMigration>(entity =>
            {
                entity.ToTable("django_migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .HasMaxLength(255)
                    .HasColumnName("app");

                entity.Property(e => e.Applied).HasColumnName("applied");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DjangoSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("django_session_pkey");

                entity.ToTable("django_session");

                entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

                entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(40)
                    .HasColumnName("session_key");

                entity.Property(e => e.ExpireDate).HasColumnName("expire_date");

                entity.Property(e => e.SessionData).HasColumnName("session_data");
            });

            modelBuilder.Entity<EditAddressesUpdated>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("edit_addresses_updated");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.AfterExtraction).HasColumnName("after_extraction");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Governorateid).HasColumnName("governorateid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.ReviewAfterExtraction).HasColumnName("review_after_extraction");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.HasIndex(e => e.Companyid, "comid");

                entity.HasIndex(e => e.Teamid, "teamid");

                entity.Property(e => e.Adress)
                    .HasColumnType("character varying")
                    .HasColumnName("adress");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CompanyName)
                    .HasColumnType("character varying")
                    .HasColumnName("company_name");

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Email)
                    .HasColumnType("character varying")
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Phone2)
                    .HasColumnType("character varying")
                    .HasColumnName("phone2");

                entity.Property(e => e.Photo).HasColumnName("photo");

                entity.Property(e => e.Teamid).HasColumnName("teamid");
            });

            modelBuilder.Entity<ErroDecumentation>(entity =>
            {
                entity.ToTable("erro_decumentation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Createby)
                    .HasColumnType("character varying")
                    .HasColumnName("createby");

                entity.Property(e => e.IssueDate).HasColumnName("issue_date");

                entity.Property(e => e.IssueDescription).HasColumnName("issue_description");

                entity.Property(e => e.IssueLocation).HasColumnName("issue_location");

                entity.Property(e => e.IssueSolve).HasColumnName("issue_solve");

                entity.Property(e => e.IssueTitle)
                    .HasColumnType("character varying")
                    .HasColumnName("issue_title");

                entity.Property(e => e.IssueType).HasColumnName("issue_type");
            });

            modelBuilder.Entity<ExrtacopiesEditStatus>(entity =>
            {
                entity.ToTable("exrtacopies_edit_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('exrtacopies_edit_status_id_seq1'::regclass)");

                entity.Property(e => e.EditStatus)
                    .HasColumnType("character varying")
                    .HasColumnName("edit_status");
            });

            modelBuilder.Entity<ExrtacopiesPrintStatus>(entity =>
            {
                entity.ToTable("exrtacopies_print_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PrintStatus)
                    .HasColumnType("character varying")
                    .HasColumnName("print_status");
            });

            modelBuilder.Entity<ExrtacopiesType>(entity =>
            {
                entity.ToTable("exrtacopies_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('exrtacopies_edit_status_id_seq'::regclass)");

                entity.Property(e => e.CopiesType)
                    .HasMaxLength(30)
                    .HasColumnName("copies_type");
            });

            modelBuilder.Entity<FieldDataReviewV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("field_data_review_v2");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.AddressDescription).HasColumnName("address_description");

                entity.Property(e => e.AfterExtraction).HasColumnName("after_extraction");

                entity.Property(e => e.ApartmentNo)
                    .HasMaxLength(10)
                    .HasColumnName("apartment_no");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AreaApartment).HasColumnName("area_apartment");

                entity.Property(e => e.AreaBerElselm).HasColumnName("area_ber_elselm");

                entity.Property(e => e.AreaBuildings).HasColumnName("area_buildings");

                entity.Property(e => e.AreaMnawer).HasColumnName("area_mnawer");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.AttachLandName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_land_name");

                entity.Property(e => e.AttachLayout)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_layout");

                entity.Property(e => e.AttachMa7darName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_ma7dar_name");

                entity.Property(e => e.AttachSelimManwarName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_selim_manwar_name");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CollectedRequest).HasColumnName("collected_request");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.FullnameOwner)
                    .HasColumnType("character varying")
                    .HasColumnName("fullname_owner");

                entity.Property(e => e.Governorateid).HasColumnName("governorateid");

                entity.Property(e => e.HodNo)
                    .HasColumnType("character varying")
                    .HasColumnName("hod_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3aNo)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a_no");

                entity.Property(e => e.LevelNo)
                    .HasMaxLength(20)
                    .HasColumnName("level_no");

                entity.Property(e => e.MappuserId)
                    .HasColumnType("character varying")
                    .HasColumnName("mappuser_id");

                entity.Property(e => e.Mar).HasColumnName("mar");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.PhoneOwner)
                    .HasColumnType("character varying")
                    .HasColumnName("phone_owner");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Repeatrefuse).HasColumnName("repeatrefuse");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.SendReview).HasColumnName("send_review");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(50)
                    .HasColumnName("subtype");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.SurveyDate)
                    .HasColumnType("character varying")
                    .HasColumnName("survey_date");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.SurveyTime).HasColumnName("survey_time");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.TotalAreaBuilding).HasColumnName("total_area_building");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");
            });

            modelBuilder.Entity<FieldDataV2>(entity =>
            {
                entity.HasKey(e => e.Requestnumber)
                    .HasName("field_data_v2_pkey");

                entity.ToTable("field_data_v2");

                entity.HasIndex(e => e.Requestnumber, "field_data_v2_index")
                    .IsUnique();

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.ApartmentNo)
                    .HasMaxLength(10)
                    .HasColumnName("apartment_no");

                entity.Property(e => e.AreaApartment).HasColumnName("area_apartment");

                entity.Property(e => e.AreaApartment2).HasColumnName("area_apartment2");

                entity.Property(e => e.AreaApartment3).HasColumnName("area_apartment3");

                entity.Property(e => e.AreaApartment4).HasColumnName("area_apartment4");

                entity.Property(e => e.AreaApartment5).HasColumnName("area_apartment5");

                entity.Property(e => e.AreaApartment6).HasColumnName("area_apartment6");

                entity.Property(e => e.AreaBerElselm).HasColumnName("area_ber_elselm");

                entity.Property(e => e.AreaBuildings).HasColumnName("area_buildings");

                entity.Property(e => e.AreaG).HasColumnName("area_g");

                entity.Property(e => e.AreaMnawer).HasColumnName("area_mnawer");

                entity.Property(e => e.Attach3aqd)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_3aqd");

                entity.Property(e => e.AttachCadImg)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_cad_img");

                entity.Property(e => e.AttachLandName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_land_name");

                entity.Property(e => e.AttachLayout)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_layout");

                entity.Property(e => e.AttachMa7darName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_ma7dar_name");

                entity.Property(e => e.AttachName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_name");

                entity.Property(e => e.AttachSelimManwarName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_selim_manwar_name");

                entity.Property(e => e.CorridorArea).HasColumnName("corridor_area");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderLengthApartment).HasColumnName("east_border_length_apartment");

                entity.Property(e => e.EastBorderLengthApartment2).HasColumnName("east_border_length_apartment2");

                entity.Property(e => e.EastBorderLengthApartment3).HasColumnName("east_border_length_apartment3");

                entity.Property(e => e.EastBorderLengthApartment4).HasColumnName("east_border_length_apartment4");

                entity.Property(e => e.EastBorderLengthApartment5).HasColumnName("east_border_length_apartment5");

                entity.Property(e => e.EastBorderLengthApartment6).HasColumnName("east_border_length_apartment6");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.EastLg).HasColumnName("east_lg");

                entity.Property(e => e.ElevatorArea).HasColumnName("elevator_area");

                entity.Property(e => e.FieldDataId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("field_data_id");

                entity.Property(e => e.ImageRefuse)
                    .HasColumnType("character varying")
                    .HasColumnName("image_refuse");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderLengthApartment).HasColumnName("north_border_length_apartment");

                entity.Property(e => e.NorthBorderLengthApartment2).HasColumnName("north_border_length_apartment2");

                entity.Property(e => e.NorthBorderLengthApartment3).HasColumnName("north_border_length_apartment3");

                entity.Property(e => e.NorthBorderLengthApartment4).HasColumnName("north_border_length_apartment4");

                entity.Property(e => e.NorthBorderLengthApartment5).HasColumnName("north_border_length_apartment5");

                entity.Property(e => e.NorthBorderLengthApartment6).HasColumnName("north_border_length_apartment6");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.NorthLg).HasColumnName("north_lg");

                entity.Property(e => e.SendReview)
                    .HasColumnName("send_review")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderLengthApartment).HasColumnName("south_border_length_apartment");

                entity.Property(e => e.SouthBorderLengthApartment2).HasColumnName("south_border_length_apartment2");

                entity.Property(e => e.SouthBorderLengthApartment3).HasColumnName("south_border_length_apartment3");

                entity.Property(e => e.SouthBorderLengthApartment4).HasColumnName("south_border_length_apartment4");

                entity.Property(e => e.SouthBorderLengthApartment5).HasColumnName("south_border_length_apartment5");

                entity.Property(e => e.SouthBorderLengthApartment6).HasColumnName("south_border_length_apartment6");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.SouthLg).HasColumnName("south_lg");

                entity.Property(e => e.SurveyDate)
                    .HasColumnType("character varying")
                    .HasColumnName("survey_date");

                entity.Property(e => e.SurveyTime).HasColumnName("survey_time");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.TotalAreaBuilding).HasColumnName("total_area_building");

                entity.Property(e => e.Usage).HasColumnName("usage");

                entity.Property(e => e.Validdate)
                    .HasMaxLength(100)
                    .HasColumnName("validdate");

                entity.Property(e => e.Validuser)
                    .HasMaxLength(100)
                    .HasColumnName("validuser");

                entity.Property(e => e.VisitDate).HasColumnName("visit_date");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderLengthApartment).HasColumnName("west_border_length_apartment");

                entity.Property(e => e.WestBorderLengthApartment2).HasColumnName("west_border_length_apartment2");

                entity.Property(e => e.WestBorderLengthApartment3).HasColumnName("west_border_length_apartment3");

                entity.Property(e => e.WestBorderLengthApartment4).HasColumnName("west_border_length_apartment4");

                entity.Property(e => e.WestBorderLengthApartment5).HasColumnName("west_border_length_apartment5");

                entity.Property(e => e.WestBorderLengthApartment6).HasColumnName("west_border_length_apartment6");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");

                entity.Property(e => e.WestLg).HasColumnName("west_lg");
            });

            modelBuilder.Entity<FieldDataViewV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("field_data_view_v2");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.AddressDescription).HasColumnName("address_description");

                entity.Property(e => e.AfterExtraction).HasColumnName("after_extraction");

                entity.Property(e => e.ApartmentNo)
                    .HasMaxLength(10)
                    .HasColumnName("apartment_no");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AreaApartment).HasColumnName("area_apartment");

                entity.Property(e => e.AreaBerElselm).HasColumnName("area_ber_elselm");

                entity.Property(e => e.AreaBuildings).HasColumnName("area_buildings");

                entity.Property(e => e.AreaMnawer).HasColumnName("area_mnawer");

                entity.Property(e => e.Areatype).HasColumnName("areatype");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.AttachLandName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_land_name");

                entity.Property(e => e.AttachLayout)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_layout");

                entity.Property(e => e.AttachMa7darName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_ma7dar_name");

                entity.Property(e => e.AttachSelimManwarName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_selim_manwar_name");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.Easternborder)
                    .HasColumnType("character varying")
                    .HasColumnName("easternborder");

                entity.Property(e => e.Easternborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("easternborderlength");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Governorateid).HasColumnName("governorateid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LevelNo)
                    .HasMaxLength(20)
                    .HasColumnName("level_no");

                entity.Property(e => e.MappuserId)
                    .HasColumnType("character varying")
                    .HasColumnName("mappuser_id");

                entity.Property(e => e.Maritimeborder)
                    .HasColumnType("character varying")
                    .HasColumnName("maritimeborder");

                entity.Property(e => e.Maritimeborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("maritimeborderlength");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestidd).HasColumnName("requestidd");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.ReviewAfterExtraction).HasColumnName("review_after_extraction");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SendReview).HasColumnName("send_review");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.SubunittypeArabicname)
                    .HasMaxLength(50)
                    .HasColumnName("subunittype_arabicname");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.SurveyDate)
                    .HasColumnType("character varying")
                    .HasColumnName("survey_date");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.SurveyTime).HasColumnName("survey_time");

                entity.Property(e => e.SuvAddress)
                    .HasMaxLength(200)
                    .HasColumnName("suv_address");

                entity.Property(e => e.TotalAreaBuilding).HasColumnName("total_area_building");

                entity.Property(e => e.Tribalborder)
                    .HasColumnType("character varying")
                    .HasColumnName("tribalborder");

                entity.Property(e => e.Tribalborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("tribalborderlength");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");

                entity.Property(e => e.Westernborder)
                    .HasColumnType("character varying")
                    .HasColumnName("westernborder");

                entity.Property(e => e.Westernborderlength)
                    .HasColumnType("character varying")
                    .HasColumnName("westernborderlength");
            });

            modelBuilder.Entity<FieldViewA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("field_view_a");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.ApartmentNo)
                    .HasMaxLength(10)
                    .HasColumnName("apartment_no");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AttachName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_name");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Geojson).HasColumnName("geojson");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LevelNo)
                    .HasMaxLength(20)
                    .HasColumnName("level_no");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Requeststatus).HasColumnName("requeststatus");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SubunittypeArabicname)
                    .HasMaxLength(50)
                    .HasColumnName("subunittype_arabicname");

                entity.Property(e => e.SurveyDate)
                    .HasColumnType("character varying")
                    .HasColumnName("survey_date");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");
            });

            modelBuilder.Entity<Fieldlookup>(entity =>
            {
                entity.HasKey(e => e.Indexid)
                    .HasName("fieldlookup_pkey");

                entity.ToTable("fieldlookup", "gdo");

                entity.Property(e => e.Indexid).HasColumnName("indexid");

                entity.Property(e => e.Featurename)
                    .HasMaxLength(127)
                    .HasColumnName("featurename");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(127)
                    .HasColumnName("fieldname");
            });

            modelBuilder.Entity<FinancialViewList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("financial_view_list");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AreaFCategory).HasColumnName("area_f_category");

                entity.Property(e => e.AreaMCategory).HasColumnName("area_m_category");

                entity.Property(e => e.AreaSCategory).HasColumnName("area_s_category");

                entity.Property(e => e.Areatype).HasColumnName("areatype");

                entity.Property(e => e.AssignStatus).HasColumnName("assign_status");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.ComType).HasColumnName("com_type");

                entity.Property(e => e.Company26).HasColumnName("company_26");

                entity.Property(e => e.Company42).HasColumnName("company_42");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.ContractRatio).HasColumnName("contract_ratio");

                entity.Property(e => e.CretRecievedMsd).HasColumnName("cret_recieved_msd");

                entity.Property(e => e.DiffreneOrderstatus).HasColumnName("diffrene_orderstatus");

                entity.Property(e => e.DiffrenePrice).HasColumnName("diffrene_price");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MainComp).HasColumnName("main_comp");

                entity.Property(e => e.NetPrice).HasColumnName("net_price");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PriceComp).HasColumnName("price_comp");

                entity.Property(e => e.PriceCompReceivable).HasColumnName("price_comp_receivable");

                entity.Property(e => e.PriceEdge).HasColumnName("price_edge");

                entity.Property(e => e.PriceEdgeReceivable).HasColumnName("price_edge_receivable");

                entity.Property(e => e.PriceEstimated).HasColumnName("price_estimated");

                entity.Property(e => e.PriceMsd).HasColumnName("price_msd");

                entity.Property(e => e.PriceMsdReceivable).HasColumnName("price_msd_receivable");

                entity.Property(e => e.PriceReceivable).HasColumnName("price_receivable");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.RequestsAreatype).HasColumnName("requests_areatype");

                entity.Property(e => e.SecondComp).HasColumnName("second_comp");

                entity.Property(e => e.Sections).HasColumnName("sections");

                entity.Property(e => e.Slide).HasColumnName("slide");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");
            });

            modelBuilder.Entity<FloorName>(entity =>
            {
                entity.ToTable("floor_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FloorName1)
                    .HasMaxLength(50)
                    .HasColumnName("floor_name");

                entity.Property(e => e.FloorNum)
                    .HasMaxLength(50)
                    .HasColumnName("floor_num");
            });

            modelBuilder.Entity<Galiastable>(entity =>
            {
                entity.HasKey(e => e.Tabletype)
                    .HasName("galiastable_pkey");

                entity.ToTable("galiastable", "gdo");

                entity.Property(e => e.Tabletype)
                    .HasMaxLength(128)
                    .HasColumnName("tabletype");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(128)
                    .HasColumnName("tablename");
            });

            modelBuilder.Entity<Gcoordsystem>(entity =>
            {
                entity.HasKey(e => e.Csguid)
                    .HasName("gcoordsystem_pkey");

                entity.ToTable("gcoordsystem", "gdo");

                entity.Property(e => e.Csguid)
                    .HasMaxLength(40)
                    .HasColumnName("csguid");

                entity.Property(e => e.Angorientationprojplanedefmode)
                    .HasColumnType("char")
                    .HasColumnName("angorientationprojplanedefmode");

                entity.Property(e => e.Argumentofperigee).HasColumnName("argumentofperigee");

                entity.Property(e => e.Averageundulation).HasColumnName("averageundulation");

                entity.Property(e => e.Azimuthangle).HasColumnName("azimuthangle");

                entity.Property(e => e.Azofupwardtilt).HasColumnName("azofupwardtilt");

                entity.Property(e => e.Basestoragetype)
                    .HasColumnType("char")
                    .HasColumnName("basestoragetype");

                entity.Property(e => e.Chamtriorigindefmode)
                    .HasColumnType("char")
                    .HasColumnName("chamtriorigindefmode");

                entity.Property(e => e.Csguidtype).HasColumnName("csguidtype");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .HasColumnName("description");

                entity.Property(e => e.Earthrotperiod).HasColumnName("earthrotperiod");

                entity.Property(e => e.Ellipsoid).HasColumnName("ellipsoid");

                entity.Property(e => e.Equatorialradius).HasColumnName("equatorialradius");

                entity.Property(e => e.Extendprojmatrix1).HasColumnName("extendprojmatrix1");

                entity.Property(e => e.Extendprojmatrix10).HasColumnName("extendprojmatrix10");

                entity.Property(e => e.Extendprojmatrix11).HasColumnName("extendprojmatrix11");

                entity.Property(e => e.Extendprojmatrix12).HasColumnName("extendprojmatrix12");

                entity.Property(e => e.Extendprojmatrix13).HasColumnName("extendprojmatrix13");

                entity.Property(e => e.Extendprojmatrix14).HasColumnName("extendprojmatrix14");

                entity.Property(e => e.Extendprojmatrix15).HasColumnName("extendprojmatrix15");

                entity.Property(e => e.Extendprojmatrix16).HasColumnName("extendprojmatrix16");

                entity.Property(e => e.Extendprojmatrix2).HasColumnName("extendprojmatrix2");

                entity.Property(e => e.Extendprojmatrix3).HasColumnName("extendprojmatrix3");

                entity.Property(e => e.Extendprojmatrix4).HasColumnName("extendprojmatrix4");

                entity.Property(e => e.Extendprojmatrix5).HasColumnName("extendprojmatrix5");

                entity.Property(e => e.Extendprojmatrix6).HasColumnName("extendprojmatrix6");

                entity.Property(e => e.Extendprojmatrix7).HasColumnName("extendprojmatrix7");

                entity.Property(e => e.Extendprojmatrix8).HasColumnName("extendprojmatrix8");

                entity.Property(e => e.Extendprojmatrix9).HasColumnName("extendprojmatrix9");

                entity.Property(e => e.Falsex).HasColumnName("falsex");

                entity.Property(e => e.Falsey).HasColumnName("falsey");

                entity.Property(e => e.Focallength).HasColumnName("focallength");

                entity.Property(e => e.Fourierexpansiondegree)
                    .HasColumnType("char")
                    .HasColumnName("fourierexpansiondegree");

                entity.Property(e => e.Gaussianlat).HasColumnName("gaussianlat");

                entity.Property(e => e.Geodeticdatum).HasColumnName("geodeticdatum");

                entity.Property(e => e.Geomheightoforig).HasColumnName("geomheightoforig");

                entity.Property(e => e.Geomheightofpoint1).HasColumnName("geomheightofpoint1");

                entity.Property(e => e.Geomheightofpoint2).HasColumnName("geomheightofpoint2");

                entity.Property(e => e.Heightaboveellipatnadir).HasColumnName("heightaboveellipatnadir");

                entity.Property(e => e.Heightorigoflocalhorizsys).HasColumnName("heightorigoflocalhorizsys");

                entity.Property(e => e.Heightstoragetype)
                    .HasColumnType("char")
                    .HasColumnName("heightstoragetype");

                entity.Property(e => e.Hemisphere)
                    .HasColumnType("char")
                    .HasColumnName("hemisphere");

                entity.Property(e => e.Inverseflattening).HasColumnName("inverseflattening");

                entity.Property(e => e.Latofbasispointa).HasColumnName("latofbasispointa");

                entity.Property(e => e.Latofbasispointb).HasColumnName("latofbasispointb");

                entity.Property(e => e.Latofbasispointc).HasColumnName("latofbasispointc");

                entity.Property(e => e.Latofmapcenter).HasColumnName("latofmapcenter");

                entity.Property(e => e.Latoforigin).HasColumnName("latoforigin");

                entity.Property(e => e.Latofpoint1).HasColumnName("latofpoint1");

                entity.Property(e => e.Latofpoint2).HasColumnName("latofpoint2");

                entity.Property(e => e.Latoftruescale).HasColumnName("latoftruescale");

                entity.Property(e => e.Latorigoflocalhorizsys).HasColumnName("latorigoflocalhorizsys");

                entity.Property(e => e.Locationofprojplanedefmode).HasColumnName("locationofprojplanedefmode");

                entity.Property(e => e.Lonnormstorageopt)
                    .HasColumnType("char")
                    .HasColumnName("lonnormstorageopt");

                entity.Property(e => e.Lonofbasispointa).HasColumnName("lonofbasispointa");

                entity.Property(e => e.Lonofbasispointb).HasColumnName("lonofbasispointb");

                entity.Property(e => e.Lonofbasispointc).HasColumnName("lonofbasispointc");

                entity.Property(e => e.Lonoforigin).HasColumnName("lonoforigin");

                entity.Property(e => e.Lonofpoint1).HasColumnName("lonofpoint1");

                entity.Property(e => e.Lonofpoint2).HasColumnName("lonofpoint2");

                entity.Property(e => e.Lonorigoflocalhorizsys).HasColumnName("lonorigoflocalhorizsys");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namedgeodeticdatum)
                    .HasMaxLength(100)
                    .HasColumnName("namedgeodeticdatum");

                entity.Property(e => e.Nodesinsimpsonintegration)
                    .HasColumnType("char")
                    .HasColumnName("nodesinsimpsonintegration");

                entity.Property(e => e.Obllamconfcondefmode)
                    .HasColumnType("char")
                    .HasColumnName("obllamconfcondefmode");

                entity.Property(e => e.Oblmercdefmode)
                    .HasColumnType("char")
                    .HasColumnName("oblmercdefmode");

                entity.Property(e => e.Orbearthrotperiodratio).HasColumnName("orbearthrotperiodratio");

                entity.Property(e => e.Orbecc).HasColumnName("orbecc");

                entity.Property(e => e.Orbinclination).HasColumnName("orbinclination");

                entity.Property(e => e.Orboff).HasColumnName("orboff");

                entity.Property(e => e.Orbperiod).HasColumnName("orbperiod");

                entity.Property(e => e.Orbsemimajaxis).HasColumnName("orbsemimajaxis");

                entity.Property(e => e.Pathnumber).HasColumnName("pathnumber");

                entity.Property(e => e.Perspcentergeocx).HasColumnName("perspcentergeocx");

                entity.Property(e => e.Perspcentergeocy).HasColumnName("perspcentergeocy");

                entity.Property(e => e.Perspcentergeocz).HasColumnName("perspcentergeocz");

                entity.Property(e => e.Perspcenterheight).HasColumnName("perspcenterheight");

                entity.Property(e => e.Perspcenterlat).HasColumnName("perspcenterlat");

                entity.Property(e => e.Perspcenterlon).HasColumnName("perspcenterlon");

                entity.Property(e => e.Perspcenterxeast).HasColumnName("perspcenterxeast");

                entity.Property(e => e.Perspcenterynorth).HasColumnName("perspcenterynorth");

                entity.Property(e => e.Perspcenterzup).HasColumnName("perspcenterzup");

                entity.Property(e => e.Projalgorithm).HasColumnName("projalgorithm");

                entity.Property(e => e.Radofstandcircle).HasColumnName("radofstandcircle");

                entity.Property(e => e.Refcoordsysdefmode)
                    .HasColumnType("char")
                    .HasColumnName("refcoordsysdefmode");

                entity.Property(e => e.Rotaboutxaxis).HasColumnName("rotaboutxaxis");

                entity.Property(e => e.Rotaboutyaxis).HasColumnName("rotaboutyaxis");

                entity.Property(e => e.Rotaboutzaxis).HasColumnName("rotaboutzaxis");

                entity.Property(e => e.Rotnorthpolelat).HasColumnName("rotnorthpolelat");

                entity.Property(e => e.Rotnorthpolelon).HasColumnName("rotnorthpolelon");

                entity.Property(e => e.Rownumber).HasColumnName("rownumber");

                entity.Property(e => e.Satellite).HasColumnName("satellite");

                entity.Property(e => e.Scalereductfact).HasColumnName("scalereductfact");

                entity.Property(e => e.Sphermodel).HasColumnName("sphermodel");

                entity.Property(e => e.Spherradius).HasColumnName("spherradius");

                entity.Property(e => e.Standpar1).HasColumnName("standpar1");

                entity.Property(e => e.Standpar2).HasColumnName("standpar2");

                entity.Property(e => e.Stor2compmatrix1).HasColumnName("stor2compmatrix1");

                entity.Property(e => e.Stor2compmatrix10).HasColumnName("stor2compmatrix10");

                entity.Property(e => e.Stor2compmatrix11).HasColumnName("stor2compmatrix11");

                entity.Property(e => e.Stor2compmatrix12).HasColumnName("stor2compmatrix12");

                entity.Property(e => e.Stor2compmatrix13).HasColumnName("stor2compmatrix13");

                entity.Property(e => e.Stor2compmatrix14).HasColumnName("stor2compmatrix14");

                entity.Property(e => e.Stor2compmatrix15).HasColumnName("stor2compmatrix15");

                entity.Property(e => e.Stor2compmatrix16).HasColumnName("stor2compmatrix16");

                entity.Property(e => e.Stor2compmatrix2).HasColumnName("stor2compmatrix2");

                entity.Property(e => e.Stor2compmatrix3).HasColumnName("stor2compmatrix3");

                entity.Property(e => e.Stor2compmatrix4).HasColumnName("stor2compmatrix4");

                entity.Property(e => e.Stor2compmatrix5).HasColumnName("stor2compmatrix5");

                entity.Property(e => e.Stor2compmatrix6).HasColumnName("stor2compmatrix6");

                entity.Property(e => e.Stor2compmatrix7).HasColumnName("stor2compmatrix7");

                entity.Property(e => e.Stor2compmatrix8).HasColumnName("stor2compmatrix8");

                entity.Property(e => e.Stor2compmatrix9).HasColumnName("stor2compmatrix9");

                entity.Property(e => e.Swingang).HasColumnName("swingang");

                entity.Property(e => e.Tiltang).HasColumnName("tiltang");

                entity.Property(e => e.Undulationmodel).HasColumnName("undulationmodel");

                entity.Property(e => e.Verticaldatum).HasColumnName("verticaldatum");

                entity.Property(e => e.Xazdefopt)
                    .HasColumnType("char")
                    .HasColumnName("xazdefopt");

                entity.Property(e => e.Zone).HasColumnName("zone");
            });

            modelBuilder.Entity<Geometryproperty>(entity =>
            {
                entity.HasKey(e => e.Indexid)
                    .HasName("geometryproperties_pkey");

                entity.ToTable("geometryproperties", "gdo");

                entity.Property(e => e.Indexid)
                    .ValueGeneratedNever()
                    .HasColumnName("indexid");

                entity.Property(e => e.Fielddescription)
                    .HasMaxLength(255)
                    .HasColumnName("fielddescription");

                entity.Property(e => e.Gcoordsystemguid)
                    .HasMaxLength(255)
                    .HasColumnName("gcoordsystemguid");

                entity.Property(e => e.Geometrytype).HasColumnName("geometrytype");

                entity.Property(e => e.Primarygeometryflag).HasColumnName("primarygeometryflag");
            });

            modelBuilder.Entity<Gfeature>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("gfeatures", "gdo");

                entity.Property(e => e.Ctid).HasColumnName("ctid");

                entity.Property(e => e.Featuredescription)
                    .HasMaxLength(255)
                    .HasColumnName("featuredescription");

                entity.Property(e => e.Featurename)
                    .HasMaxLength(127)
                    .HasColumnName("featurename");

                entity.Property(e => e.Geometrytype).HasColumnName("geometrytype");

                entity.Property(e => e.Primarygeometryfieldname)
                    .HasMaxLength(127)
                    .HasColumnName("primarygeometryfieldname");
            });

            modelBuilder.Entity<Gfeaturesbase>(entity =>
            {
                entity.HasKey(e => e.Featurename)
                    .HasName("gfeaturesbase_pkey");

                entity.ToTable("gfeaturesbase", "gdo");

                entity.Property(e => e.Featurename)
                    .HasMaxLength(127)
                    .HasColumnName("featurename");

                entity.Property(e => e.Featuredescription)
                    .HasMaxLength(255)
                    .HasColumnName("featuredescription");

                entity.Property(e => e.Geometrytype).HasColumnName("geometrytype");

                entity.Property(e => e.Primarygeometryfieldname)
                    .HasMaxLength(127)
                    .HasColumnName("primarygeometryfieldname");
            });

            modelBuilder.Entity<Gov3857>(entity =>
            {
                entity.ToTable("gov_3857");

                entity.HasIndex(e => e.Id, "govs")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gov)
                    .HasMaxLength(254)
                    .HasColumnName("gov");

                entity.Property(e => e.GovCode)
                    .HasMaxLength(254)
                    .HasColumnName("gov_code");

                entity.Property(e => e.GovNameE)
                    .HasMaxLength(100)
                    .HasColumnName("gov_name_e");

                entity.Property(e => e.Objectid).HasColumnName("objectid");
            });

            modelBuilder.Entity<GovReqCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("gov_req_count");

                entity.Property(e => e.Gov)
                    .HasMaxLength(254)
                    .HasColumnName("gov");

                entity.Property(e => e.GovCode).HasColumnName("gov_code");

                entity.Property(e => e.ReqCount).HasColumnName("req_count");
            });

            modelBuilder.Entity<Governorate>(entity =>
            {
                entity.ToTable("governorates");

                entity.HasIndex(e => e.Arabicname, "gov_name");

                entity.HasIndex(e => e.Id, "governorates_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasMaxLength(255)
                    .HasColumnName("addeddate")
                    .IsFixedLength();

                entity.Property(e => e.Arabicname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicname");

                entity.Property(e => e.Crewtransfercost).HasColumnName("crewtransfercost");

                entity.Property(e => e.Englishname)
                    .HasMaxLength(200)
                    .HasColumnName("englishname");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .HasColumnName("latitude")
                    .IsFixedLength();

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .HasColumnName("longitude")
                    .IsFixedLength();

                entity.Property(e => e.Modifieddate)
                    .HasMaxLength(255)
                    .HasColumnName("modifieddate")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gparameter>(entity =>
            {
                entity.HasKey(e => e.Gparameter1)
                    .HasName("gparameters_pkey");

                entity.ToTable("gparameters", "gdo");

                entity.Property(e => e.Gparameter1)
                    .HasMaxLength(63)
                    .HasColumnName("gparameter");

                entity.Property(e => e.Gvalue)
                    .HasMaxLength(255)
                    .HasColumnName("gvalue");
            });

            modelBuilder.Entity<Gpicklisttable>(entity =>
            {
                entity.HasKey(e => new { e.Featurename, e.Fieldname })
                    .HasName("gpicklisttable_pkey");

                entity.ToTable("gpicklisttable", "gdo");

                entity.Property(e => e.Featurename)
                    .HasMaxLength(127)
                    .HasColumnName("featurename");

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(127)
                    .HasColumnName("fieldname");

                entity.Property(e => e.Descriptionfieldname)
                    .HasMaxLength(127)
                    .HasColumnName("descriptionfieldname");

                entity.Property(e => e.Filterclause)
                    .HasMaxLength(255)
                    .HasColumnName("filterclause");

                entity.Property(e => e.Picklisttablename)
                    .HasMaxLength(127)
                    .HasColumnName("picklisttablename");

                entity.Property(e => e.Valuefieldname)
                    .HasMaxLength(127)
                    .HasColumnName("valuefieldname");
            });

            modelBuilder.Entity<Gsqloperatortable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gsqloperatortable", "gdo");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Operator)
                    .HasMaxLength(32)
                    .HasColumnName("operator");

                entity.Property(e => e.Operatorclass)
                    .HasMaxLength(100)
                    .HasColumnName("operatorclass");
            });

            modelBuilder.Entity<InquiryreqeustsUpdated>(entity =>
            {
                entity.ToTable("inquiryreqeusts_updated");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AcceptanceStatus)
                    .HasColumnType("character varying")
                    .HasColumnName("acceptance_status");

                entity.Property(e => e.Attachment)
                    .HasColumnType("character varying")
                    .HasColumnName("attachment");

                entity.Property(e => e.CreatedDate)
                    .HasPrecision(4)
                    .HasColumnName("created_date");

                entity.Property(e => e.EstmaraNo)
                    .HasColumnType("character varying")
                    .HasColumnName("estmara_no");

                entity.Property(e => e.LandNo)
                    .HasColumnType("character varying")
                    .HasColumnName("land_no");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Notes)
                    .HasColumnType("character varying")
                    .HasColumnName("notes");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.SegalType)
                    .HasColumnType("character varying")
                    .HasColumnName("segal_type");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TankNo)
                    .HasColumnType("character varying")
                    .HasColumnName("tank_no");

                entity.Property(e => e.UpdatedDate)
                    .HasPrecision(4)
                    .HasColumnName("updated_date");

                entity.Property(e => e.UserCreated)
                    .HasColumnType("character varying")
                    .HasColumnName("user_created");

                entity.Property(e => e.UserUpdated)
                    .HasColumnType("character varying")
                    .HasColumnName("user_updated");
            });

            modelBuilder.Entity<InquiryreqeustsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("inquiryreqeusts_view");

                entity.Property(e => e.AcceptanceStatus)
                    .HasColumnType("character varying")
                    .HasColumnName("acceptance_status");

                entity.Property(e => e.Attachment)
                    .HasColumnType("character varying")
                    .HasColumnName("attachment");

                entity.Property(e => e.CollectStatus).HasColumnName("collect_status");

                entity.Property(e => e.EstmaraNo)
                    .HasColumnType("character varying")
                    .HasColumnName("estmara_no");

                entity.Property(e => e.Fullname)
                    .HasColumnType("character varying")
                    .HasColumnName("fullname");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.InqStatus).HasColumnName("inq_status");

                entity.Property(e => e.LandNo)
                    .HasColumnType("character varying")
                    .HasColumnName("land_no");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Notes)
                    .HasColumnType("character varying")
                    .HasColumnName("notes");

                entity.Property(e => e.Orderstatuss).HasColumnName("orderstatuss");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.PrintStatuss).HasColumnName("print_statuss");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.SegalType)
                    .HasColumnType("character varying")
                    .HasColumnName("segal_type");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.TankNo)
                    .HasColumnType("character varying")
                    .HasColumnName("tank_no");
            });

            modelBuilder.Entity<Inquiryrequest>(entity =>
            {
                entity.ToTable("inquiryrequests");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Inquiryrequeststatus).HasColumnName("inquiryrequeststatus");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Requestid).HasColumnName("requestid");
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.ToTable("issue");

                entity.HasIndex(e => e.Requestnumber, "issue_req");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnType("character varying")
                    .HasColumnName("comment");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Librarytable>(entity =>
            {
                entity.HasKey(e => e.Tabletype)
                    .HasName("librarytables_pkey");

                entity.ToTable("librarytables", "gdo");

                entity.Property(e => e.Tabletype)
                    .HasMaxLength(255)
                    .HasColumnName("tabletype");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(255)
                    .HasColumnName("tablename");
            });

            modelBuilder.Entity<LkupRefuseReason>(entity =>
            {
                entity.ToTable("lkup_refuse_reason");

                entity.HasIndex(e => e.Id, "lkup")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LkupUnittype>(entity =>
            {
                entity.ToTable("lkup_unittype");

                entity.HasIndex(e => e.Id, "un_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LukpTransactionType>(entity =>
            {
                entity.ToTable("lukp_transaction_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<MappUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapp_user");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(64)
                    .HasColumnName("fullname");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.Isactivated).HasColumnName("isactivated");

                entity.Property(e => e.Isactivedirectory).HasColumnName("isactivedirectory");

                entity.Property(e => e.Isstudioaccount).HasColumnName("isstudioaccount");

                entity.Property(e => e.Istwofactorrequired).HasColumnName("istwofactorrequired");

                entity.Property(e => e.Languagecode)
                    .HasMaxLength(10)
                    .HasColumnName("languagecode");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(64)
                    .HasColumnName("password");

                entity.Property(e => e.Twofactorsecret)
                    .HasMaxLength(256)
                    .HasColumnName("twofactorsecret");
            });

            modelBuilder.Entity<MappUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapp_user_role");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("role_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<Modificationlog>(entity =>
            {
                entity.HasKey(e => e.Modificationnumber)
                    .HasName("modificationlog_pkey");

                entity.ToTable("modificationlog", "gdo");

                entity.Property(e => e.Modificationnumber).HasColumnName("modificationnumber");

                entity.Property(e => e.Keyvalue1)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue1");

                entity.Property(e => e.Keyvalue10)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue10");

                entity.Property(e => e.Keyvalue2)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue2");

                entity.Property(e => e.Keyvalue3)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue3");

                entity.Property(e => e.Keyvalue4)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue4");

                entity.Property(e => e.Keyvalue5)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue5");

                entity.Property(e => e.Keyvalue6)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue6");

                entity.Property(e => e.Keyvalue7)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue7");

                entity.Property(e => e.Keyvalue8)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue8");

                entity.Property(e => e.Keyvalue9)
                    .HasMaxLength(255)
                    .HasColumnName("keyvalue9");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Modifiedtableid).HasColumnName("modifiedtableid");

                entity.Property(e => e.Sessionid).HasColumnName("sessionid");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Modifiedtable>(entity =>
            {
                entity.ToTable("modifiedtables", "gdo");

                entity.HasIndex(e => e.Tablename, "modifiedtables_tablename_key")
                    .IsUnique();

                entity.Property(e => e.Modifiedtableid).HasColumnName("modifiedtableid");

                entity.Property(e => e.Keyfield1)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield1");

                entity.Property(e => e.Keyfield10)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield10");

                entity.Property(e => e.Keyfield2)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield2");

                entity.Property(e => e.Keyfield3)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield3");

                entity.Property(e => e.Keyfield4)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield4");

                entity.Property(e => e.Keyfield5)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield5");

                entity.Property(e => e.Keyfield6)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield6");

                entity.Property(e => e.Keyfield7)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield7");

                entity.Property(e => e.Keyfield8)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield8");

                entity.Property(e => e.Keyfield9)
                    .HasMaxLength(127)
                    .HasColumnName("keyfield9");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(127)
                    .HasColumnName("tablename");
            });

            modelBuilder.Entity<Nezar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("nezar");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.EditStatus).HasColumnName("edit_status");

                entity.Property(e => e.Editcertificateinformation)
                    .HasColumnType("character varying")
                    .HasColumnName("editcertificateinformation");

                entity.Property(e => e.Extracopiesprice).HasColumnName("extracopiesprice");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Numberofcopies).HasColumnName("numberofcopies");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.OverlapStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_status");

                entity.Property(e => e.OverlapStatuss).HasColumnName("overlap_statuss");

                entity.Property(e => e.Paidstatus).HasColumnName("paidstatus");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.PrintStatuss).HasColumnName("print_statuss");

                entity.Property(e => e.Recert).HasColumnName("recert");

                entity.Property(e => e.Recertt).HasColumnName("recertt");

                entity.Property(e => e.RequestCount).HasColumnName("request_count");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusDate).HasColumnName("status_date");

                entity.Property(e => e.Statuss).HasColumnName("statuss");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");
            });

            modelBuilder.Entity<Nezar2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("nezar2");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.EditStatus).HasColumnName("edit_status");

                entity.Property(e => e.Editcertificateinformation)
                    .HasColumnType("character varying")
                    .HasColumnName("editcertificateinformation");

                entity.Property(e => e.Extracopiesprice).HasColumnName("extracopiesprice");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Numberofcopies).HasColumnName("numberofcopies");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.OverlapStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_status");

                entity.Property(e => e.OverlapStatuss).HasColumnName("overlap_statuss");

                entity.Property(e => e.Paidstatus).HasColumnName("paidstatus");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.PrintStatuss).HasColumnName("print_statuss");

                entity.Property(e => e.Recert).HasColumnName("recert");

                entity.Property(e => e.Recertt).HasColumnName("recertt");

                entity.Property(e => e.RequestCount).HasColumnName("request_count");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusDate).HasColumnName("status_date");

                entity.Property(e => e.Statuss).HasColumnName("statuss");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");
            });

            modelBuilder.Entity<Nezar3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("nezar3");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.EditStatus).HasColumnName("edit_status");

                entity.Property(e => e.Editcertificateinformation)
                    .HasColumnType("character varying")
                    .HasColumnName("editcertificateinformation");

                entity.Property(e => e.Extracopiesprice).HasColumnName("extracopiesprice");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Numberofcopies).HasColumnName("numberofcopies");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.OverlapStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_status");

                entity.Property(e => e.OverlapStatuss).HasColumnName("overlap_statuss");

                entity.Property(e => e.Paidstatus).HasColumnName("paidstatus");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.PrintStatuss).HasColumnName("print_statuss");

                entity.Property(e => e.Recert).HasColumnName("recert");

                entity.Property(e => e.Recertt).HasColumnName("recertt");

                entity.Property(e => e.RequestCount).HasColumnName("request_count");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusDate).HasColumnName("status_date");

                entity.Property(e => e.Statuss).HasColumnName("statuss");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");
            });

            modelBuilder.Entity<Nsdi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("nsdi");

                entity.Property(e => e.Addeddate).HasColumnName("addeddate");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.AddressDescription).HasColumnName("address_description");

                entity.Property(e => e.AfterExtraction).HasColumnName("after_extraction");

                entity.Property(e => e.ApartmentNo)
                    .HasMaxLength(10)
                    .HasColumnName("apartment_no");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.AreaApartment).HasColumnName("area_apartment");

                entity.Property(e => e.AreaBerElselm).HasColumnName("area_ber_elselm");

                entity.Property(e => e.AreaBuildings).HasColumnName("area_buildings");

                entity.Property(e => e.AreaMnawer).HasColumnName("area_mnawer");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.AttachLandName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_land_name");

                entity.Property(e => e.AttachLayout)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_layout");

                entity.Property(e => e.AttachMa7darName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_ma7dar_name");

                entity.Property(e => e.AttachSelimManwarName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_selim_manwar_name");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CollectedRequest).HasColumnName("collected_request");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.FullnameOwner)
                    .HasColumnType("character varying")
                    .HasColumnName("fullname_owner");

                entity.Property(e => e.Governorateid).HasColumnName("governorateid");

                entity.Property(e => e.HodNo)
                    .HasColumnType("character varying")
                    .HasColumnName("hod_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ket3aNo)
                    .HasColumnType("character varying")
                    .HasColumnName("ket3a_no");

                entity.Property(e => e.LevelNo)
                    .HasMaxLength(20)
                    .HasColumnName("level_no");

                entity.Property(e => e.MappuserId)
                    .HasColumnType("character varying")
                    .HasColumnName("mappuser_id");

                entity.Property(e => e.Mar).HasColumnName("mar");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.PhoneOwner)
                    .HasColumnType("character varying")
                    .HasColumnName("phone_owner");

                entity.Property(e => e.Phonenumber).HasColumnName("phonenumber");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Repeatrefuse).HasColumnName("repeatrefuse");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.SendReview).HasColumnName("send_review");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.Subtype)
                    .HasMaxLength(50)
                    .HasColumnName("subtype");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.SurveyDate)
                    .HasColumnType("character varying")
                    .HasColumnName("survey_date");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.SurveyTeamId).HasColumnName("survey_team_id");

                entity.Property(e => e.SurveyTime).HasColumnName("survey_time");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.TotalAreaBuilding).HasColumnName("total_area_building");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");

                entity.Property(e => e.Usage)
                    .HasColumnType("character varying")
                    .HasColumnName("usage");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("office");

                entity.HasIndex(e => e.Id, "office_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Arabicaddress)
                    .HasColumnType("character varying")
                    .HasColumnName("arabicaddress");

                entity.Property(e => e.Englishaddress)
                    .HasColumnType("character varying")
                    .HasColumnName("englishaddress");

                entity.Property(e => e.Gpslocation)
                    .HasColumnType("character varying")
                    .HasColumnName("gpslocation");

                entity.Property(e => e.Latitude)
                    .HasColumnType("character varying")
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasColumnType("character varying")
                    .HasColumnName("longitude");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Regionid).HasColumnName("regionid");
            });

            modelBuilder.Entity<Orderstatus>(entity =>
            {
                entity.HasKey(e => e.Orderstatusreference)
                    .HasName("orderstatus_pkey");

                entity.ToTable("orderstatus");

                entity.Property(e => e.Orderstatusreference)
                    .ValueGeneratedNever()
                    .HasColumnName("orderstatusreference");

                entity.Property(e => e.Orderstatusname)
                    .HasColumnType("character varying")
                    .HasColumnName("orderstatusname");
            });

            modelBuilder.Entity<Paymenttrasnsaction>(entity =>
            {
                entity.ToTable("paymenttrasnsactions");

                entity.HasIndex(e => e.Requestid, "pay_requestid");

                entity.HasIndex(e => e.Referencenumber, "ref");

                entity.HasIndex(e => e.Nquiryrequestid, "req_inq");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Deliverydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("deliverydate");

                entity.Property(e => e.Fawryaccounttype)
                    .HasColumnName("fawryaccounttype")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fawryfees).HasColumnName("fawryfees");

                entity.Property(e => e.Merchantrefnum)
                    .HasMaxLength(100)
                    .HasColumnName("merchantrefnum")
                    .IsFixedLength();

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Nquiryrequestid).HasColumnName("nquiryrequestid");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.Paymentamount).HasColumnName("paymentamount");

                entity.Property(e => e.Paymentmethod).HasColumnName("paymentmethod");

                entity.Property(e => e.Paymenttime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paymenttime");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Referencenumber)
                    .HasMaxLength(255)
                    .HasColumnName("referencenumber")
                    .IsFixedLength();

                entity.Property(e => e.Refundedamount).HasColumnName("refundedamount");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Statuscode)
                    .HasColumnType("character varying")
                    .HasColumnName("statuscode");

                entity.Property(e => e.Statusdescription)
                    .HasColumnType("character varying")
                    .HasColumnName("statusdescription");

                entity.Property(e => e.Transactiontype).HasColumnName("transactiontype");

                entity.Property(e => e.Userid)
                    .HasColumnType("character varying")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("regions");

                entity.HasIndex(e => e.Id, "reg")
                    .IsUnique();

                entity.Property(e => e.Addeddate)
                    .HasMaxLength(255)
                    .HasColumnName("addeddate")
                    .IsFixedLength();

                entity.Property(e => e.Arabicname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicname");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Crewtransfercost).HasColumnName("crewtransfercost");

                entity.Property(e => e.Englishname)
                    .HasMaxLength(200)
                    .HasColumnName("englishname");

                entity.Property(e => e.Governorateid).HasColumnName("governorateid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(255)
                    .HasColumnName("latitude")
                    .IsFixedLength();

                entity.Property(e => e.Longitude)
                    .HasMaxLength(255)
                    .HasColumnName("longitude")
                    .IsFixedLength();

                entity.Property(e => e.Modifieddate)
                    .HasMaxLength(255)
                    .HasColumnName("modifieddate")
                    .IsFixedLength();

                entity.Property(e => e.Surveyteamid)
                    .HasColumnName("surveyteamid")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Requestnumber })
                    .HasName("requests_pkey");

                entity.ToTable("requests");

                entity.HasIndex(e => e.Id, "req_id");

                entity.HasIndex(e => e.Requestnumber, "requestnum");

                entity.HasIndex(e => e.Unittype, "unit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Areatype).HasColumnName("areatype");

                entity.Property(e => e.Assigned)
                    .HasColumnName("assigned")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Buildingarea)
                    .HasColumnType("character varying")
                    .HasColumnName("buildingarea");

                entity.Property(e => e.Crewtransfercost).HasColumnName("crewtransfercost");

                entity.Property(e => e.Deliverydate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("deliverydate");

                entity.Property(e => e.Hasinquiryrequest)
                    .HasColumnType("bit(1)")
                    .HasColumnName("hasinquiryrequest")
                    .HasDefaultValueSql("(0)::bit(1)");

                entity.Property(e => e.Haspricedifference).HasColumnName("haspricedifference");

                entity.Property(e => e.Isarchived).HasColumnName("isarchived");

                entity.Property(e => e.Ispaid).HasColumnName("ispaid");

                entity.Property(e => e.Landarea)
                    .HasColumnType("character varying")
                    .HasColumnName("landarea");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Paymentdifferenceamount).HasColumnName("paymentdifferenceamount");

                entity.Property(e => e.Paymentstatus).HasColumnName("paymentstatus");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Requeststatus).HasColumnName("requeststatus");

                entity.Property(e => e.Statusdescription)
                    .HasColumnType("character varying")
                    .HasColumnName("statusdescription");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.Unittype).HasColumnName("unittype");

                entity.Property(e => e.Userid)
                    .HasColumnType("character varying")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<RequestPrice>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<RequestTawheed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("request_tawheed");

                entity.Property(e => e.AreaBerElselm).HasColumnName("area_ber_elselm");

                entity.Property(e => e.AreaBuildings).HasColumnName("area_buildings");

                entity.Property(e => e.AreaMnawer).HasColumnName("area_mnawer");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CorridorArea).HasColumnName("corridor_area");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.ElevatorArea).HasColumnName("elevator_area");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(21)
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.Tawheed).HasColumnName("tawheed");

                entity.Property(e => e.TawheedStatus).HasColumnName("tawheed_status");

                entity.Property(e => e.TotalAreaBuilding).HasColumnName("total_area_building");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");
            });

            modelBuilder.Entity<RequestTrip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("request_trip");

                entity.Property(e => e.AcceptedDate).HasColumnName("accepted_date");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Paymenttime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("paymenttime");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Shippstatus).HasColumnName("shippstatus");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            });

            modelBuilder.Entity<Requestpricedifference>(entity =>
            {
                entity.ToTable("requestpricedifferences");

                entity.HasIndex(e => e.Requestid, "difff");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Areadifference).HasColumnName("areadifference");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Requestareadifferencestatus).HasColumnName("requestareadifferencestatus");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Subunitareadifference).HasColumnName("subunitareadifference");
            });

            modelBuilder.Entity<RequestsExtrainfo>(entity =>
            {
                entity.ToTable("requests_extrainfo");

                entity.HasIndex(e => e.Requestnumber, "info")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateShahr).HasColumnName("date_shahr");

                entity.Property(e => e.DateTasgel).HasColumnName("date_tasgel");

                entity.Property(e => e.Fullname)
                    .HasColumnType("character varying")
                    .HasColumnName("fullname");

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.RegistrationNo)
                    .HasColumnType("character varying")
                    .HasColumnName("registration_no");

                entity.Property(e => e.RequestNo)
                    .HasColumnType("character varying")
                    .HasColumnName("request_no");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Validdate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("validdate");

                entity.Property(e => e.Validuser)
                    .HasMaxLength(50)
                    .HasColumnName("validuser");
            });

            modelBuilder.Entity<RequestsOverlap>(entity =>
            {
                entity.HasKey(e => e.Requestnumber)
                    .HasName("requests_overlap_pkey");

                entity.ToTable("requests_overlap");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.AttachOverlap)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_overlap");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MilOverlap).HasColumnName("mil_overlap");

                entity.Property(e => e.NcpsluDate).HasColumnName("ncpslu_date");

                entity.Property(e => e.NcpsluOverlap).HasColumnName("ncpslu_overlap");

                entity.Property(e => e.NcpsluStatus)
                    .HasColumnType("char")
                    .HasColumnName("ncpslu_status");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.OverlapDate).HasColumnName("overlap_date");

                entity.Property(e => e.OverlapResponsibility)
                    .HasColumnType("char")
                    .HasColumnName("overlap_responsibility");

                entity.Property(e => e.OverlapSendStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_send_status");

                entity.Property(e => e.OverlapStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_status");

                entity.Property(e => e.Registability)
                    .HasColumnType("char")
                    .HasColumnName("registability");
            });

            modelBuilder.Entity<RequestsOverlapNcpslu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("requests_overlap_ncpslu");

                entity.Property(e => e.Attach3aqd)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_3aqd");

                entity.Property(e => e.AttachOverlap)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_overlap");

                entity.Property(e => e.Fullname)
                    .HasColumnType("character varying")
                    .HasColumnName("fullname");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NcpsluDate).HasColumnName("ncpslu_date");

                entity.Property(e => e.NcpsluOverlap).HasColumnName("ncpslu_overlap");

                entity.Property(e => e.NcpsluStatus)
                    .HasColumnType("char")
                    .HasColumnName("ncpslu_status");

                entity.Property(e => e.NcpsluStatuss).HasColumnName("ncpslu_statuss");

                entity.Property(e => e.Overlap).HasColumnName("overlap");

                entity.Property(e => e.OverlapDate).HasColumnName("overlap_date");

                entity.Property(e => e.OverlapResponsibility)
                    .HasColumnType("char")
                    .HasColumnName("overlap_responsibility");

                entity.Property(e => e.OverlapResponsibilityy).HasColumnName("overlap_responsibilityy");

                entity.Property(e => e.OverlapSendStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_send_status");

                entity.Property(e => e.OverlapSendStatuss).HasColumnName("overlap_send_statuss");

                entity.Property(e => e.OverlapStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_status");

                entity.Property(e => e.OverlapStatuss).HasColumnName("overlap_statuss");

                entity.Property(e => e.Phone)
                    .HasColumnType("character varying")
                    .HasColumnName("phone");

                entity.Property(e => e.Registability)
                    .HasColumnType("char")
                    .HasColumnName("registability");

                entity.Property(e => e.Registabilityy).HasColumnName("registabilityy");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");
            });

            modelBuilder.Entity<Requeststatus>(entity =>
            {
                entity.ToTable("requeststatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .HasColumnType("character varying")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Sec3857>(entity =>
            {
                entity.HasKey(e => e.Id0)
                    .HasName("sec_3857_pkey");

                entity.ToTable("sec_3857");

                entity.Property(e => e.Id0).HasColumnName("id_0");

                entity.Property(e => e.GovCode)
                    .HasMaxLength(2)
                    .HasColumnName("gov_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SecCode)
                    .HasMaxLength(4)
                    .HasColumnName("sec_code");

                entity.Property(e => e.SecNameAr)
                    .HasMaxLength(100)
                    .HasColumnName("sec_name_ar");

                entity.Property(e => e.SecNameEn)
                    .HasMaxLength(100)
                    .HasColumnName("sec_name_en");
            });

            modelBuilder.Entity<SeragTewheed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("serag_tewheed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragidCount).HasColumnName("seragid_count");

                entity.Property(e => e.اسمالشارع)
                    .HasMaxLength(200)
                    .HasColumnName("اسم الشارع");

                entity.Property(e => e.رقمالعقار)
                    .HasColumnType("character varying")
                    .HasColumnName("رقم العقار");

                entity.Property(e => e.طولالحدالبحري).HasColumnName("طول الحد البحري");

                entity.Property(e => e.طولالحدالشرقي).HasColumnName("طول الحد الشرقي");

                entity.Property(e => e.طولالحدالغربي).HasColumnName("طول الحد الغربي");

                entity.Property(e => e.طولالحدالقبلي).HasColumnName("طول الحد القبلي");

                entity.Property(e => e.مساحةالأرض).HasColumnName("مساحة الأرض");

                entity.Property(e => e.مساحةالمبنى).HasColumnName("مساحة المبنى");

                entity.Property(e => e.وصفالحدالبحري)
                    .HasColumnType("character varying")
                    .HasColumnName("وصف الحد البحري");

                entity.Property(e => e.وصفالحدالشرقي)
                    .HasColumnType("character varying")
                    .HasColumnName("وصف الحد الشرقي");

                entity.Property(e => e.وصفالحدالغربي)
                    .HasColumnType("character varying")
                    .HasColumnName("وصف الحد الغربي");

                entity.Property(e => e.وصفالحدالقبلي)
                    .HasColumnType("character varying")
                    .HasColumnName("وصف الحد القبلي");

                entity.Property(e => e.وصفالمبنى).HasColumnName("وصف المبنى");
            });

            modelBuilder.Entity<ShippingView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shipping_view");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("apartment_number");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Areatype).HasColumnName("areatype");

                entity.Property(e => e.AssignmentDateTime).HasColumnName("assignment_date_time");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.CretRecievedMsd).HasColumnName("cret_recieved_msd");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.District)
                    .HasMaxLength(200)
                    .HasColumnName("district");

                entity.Property(e => e.DueDate).HasColumnName("due_date");

                entity.Property(e => e.FloorNumber)
                    .HasMaxLength(20)
                    .HasColumnName("floor_number");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.GovCode).HasColumnName("gov_code");

                entity.Property(e => e.Governorate)
                    .HasMaxLength(200)
                    .HasColumnName("governorate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PropertyNumber)
                    .HasColumnType("character varying")
                    .HasColumnName("property_number");

                entity.Property(e => e.Region)
                    .HasMaxLength(200)
                    .HasColumnName("region");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.RequestsAreatype).HasColumnName("requests_areatype");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Shipaddr)
                    .HasColumnType("character varying")
                    .HasColumnName("shipaddr");

                entity.Property(e => e.Ssec)
                    .HasMaxLength(200)
                    .HasColumnName("ssec");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyReview).HasColumnName("survey_review");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.Telephonenumber).HasColumnName("telephonenumber");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.UniqueMark)
                    .HasMaxLength(200)
                    .HasColumnName("unique_mark");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.Unittype).HasColumnName("unittype");
            });

            modelBuilder.Entity<Shippingorder>(entity =>
            {
                entity.ToTable("shippingorders");

                entity.HasIndex(e => e.Requestid, "requestidshipping");

                entity.HasIndex(e => e.Id, "shippingorders_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Apartmentnumber).HasColumnName("apartmentnumber");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.Editcertificateinformation)
                    .HasColumnType("character varying")
                    .HasColumnName("editcertificateinformation");

                entity.Property(e => e.Extracopiesprice).HasColumnName("extracopiesprice");

                entity.Property(e => e.Floornumber).HasColumnName("floornumber");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Numberofcopies).HasColumnName("numberofcopies");

                entity.Property(e => e.Officeid).HasColumnName("officeid");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.Propertynumber).HasColumnName("propertynumber");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Shippingorderstatus).HasColumnName("shippingorderstatus");

                entity.Property(e => e.Shippingprice).HasColumnName("shippingprice");

                entity.Property(e => e.Shippingtype).HasColumnName("shippingtype");

                entity.Property(e => e.Streetname)
                    .HasColumnType("character varying")
                    .HasColumnName("streetname");

                entity.Property(e => e.Uniquemark)
                    .HasColumnType("character varying")
                    .HasColumnName("uniquemark");
            });

            modelBuilder.Entity<ShippingordersNotpaid>(entity =>
            {
                entity.ToTable("shippingorders_notpaid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Con1)
                    .HasMaxLength(50)
                    .HasColumnName("con1")
                    .HasDefaultValueSql("'np'::character varying");

                entity.Property(e => e.Createdby)
                    .HasColumnType("character varying")
                    .HasColumnName("createdby");

                entity.Property(e => e.Createddate).HasColumnName("createddate");

                entity.Property(e => e.Creatednotes).HasColumnName("creatednotes");

                entity.Property(e => e.Editcertificateinformation).HasColumnName("editcertificateinformation");

                entity.Property(e => e.PhoneNotPaid).HasColumnName("phone_not_paid");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.RecertNotPaid)
                    .HasColumnType("character varying")
                    .HasColumnName("recert_not_paid");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(21)
                    .HasColumnName("requestnumber");

                entity.Property(e => e.StatusNotPaid)
                    .HasColumnType("character varying")
                    .HasColumnName("status_not_paid");

                entity.Property(e => e.SubStautsNotPaid)
                    .HasColumnType("character varying")
                    .HasColumnName("sub_stauts_not_paid");

                entity.Property(e => e.TofidexNotPaid).HasColumnName("tofidex_not_paid");
            });

            modelBuilder.Entity<ShippingordersStatus>(entity =>
            {
                entity.HasKey(e => e.IdShippingorder)
                    .HasName("shippingorders_status_pkey");

                entity.ToTable("shippingorders_status");

                entity.HasIndex(e => e.IdShippingorder, "id_shipp")
                    .IsUnique();

                entity.HasIndex(e => e.Requestnumber, "requestshipping");

                entity.Property(e => e.IdShippingorder)
                    .ValueGeneratedNever()
                    .HasColumnName("id_shippingorder");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentCompany)
                    .HasColumnType("character varying")
                    .HasColumnName("comment_company");

                entity.Property(e => e.CommentRsc)
                    .HasColumnType("character varying")
                    .HasColumnName("comment_rsc");

                entity.Property(e => e.CommentSend)
                    .HasColumnType("character varying")
                    .HasColumnName("comment_send");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.EditorComment).HasColumnName("editor_comment");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Numberofcopies).HasColumnName("numberofcopies");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.ReceiveComment)
                    .HasColumnType("character varying")
                    .HasColumnName("receive_comment");

                entity.Property(e => e.Recert).HasColumnName("recert");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusDate).HasColumnName("status_date");

                entity.Property(e => e.SubStatus).HasColumnName("sub_status");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");
            });

            modelBuilder.Entity<Shippingtype>(entity =>
            {
                entity.ToTable("shippingtype");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Shippingtype1)
                    .HasColumnType("character varying")
                    .HasColumnName("shippingtype");
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("statistics");

                entity.Property(e => e.Accept).HasColumnName("accept");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.Countrequestpricedifferences).HasColumnName("countrequestpricedifferences");

                entity.Property(e => e.Countshippingorders).HasColumnName("countshippingorders");

                entity.Property(e => e.Notcollected).HasColumnName("notcollected");

                entity.Property(e => e.Notshipped).HasColumnName("notshipped");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.Print).HasColumnName("print");

                entity.Property(e => e.Reviewsrequest).HasColumnName("reviewsrequest");

                entity.Property(e => e.Shipped).HasColumnName("shipped");

                entity.Property(e => e.Taazer).HasColumnName("taazer");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<Subunittype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("subunittype");

                entity.Property(e => e.Subunittype1).HasColumnName("subunittype");

                entity.Property(e => e.SubunittypeArabicname)
                    .HasMaxLength(50)
                    .HasColumnName("subunittype_arabicname");

                entity.Property(e => e.SubunittypeName)
                    .HasMaxLength(30)
                    .HasColumnName("subunittype_name");
            });

            modelBuilder.Entity<SurveyReviewComment>(entity =>
            {
                entity.ToTable("survey_review_comments");

                entity.HasIndex(e => e.Requestnumber, "req_num");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");
            });

            modelBuilder.Entity<SurveyReviewMsdComment>(entity =>
            {
                entity.ToTable("survey_review_msd_comments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sender).HasColumnName("sender");

                entity.Property(e => e.UserName)
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<Surveygi>(entity =>
            {
                entity.HasKey(e => e.Seragid)
                    .HasName("surveygis_seragid_pkey");

                entity.ToTable("surveygis");

                entity.HasIndex(e => e.Seragid, "gis")
                    .IsUnique();

                entity.Property(e => e.Seragid)
                    .HasColumnType("character varying")
                    .HasColumnName("seragid");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.Ids)
                    .HasColumnName("ids")
                    .HasDefaultValueSql("nextval('surveygis_id_seq'::regclass)");

                entity.Property(e => e.XValidation)
                    .HasColumnType("character varying")
                    .HasColumnName("x_validation");

                entity.Property(e => e.YValidation)
                    .HasColumnType("character varying")
                    .HasColumnName("y_validation");
            });

            modelBuilder.Entity<SurveygisView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("surveygis_view");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(21)
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragShaqaaa).HasColumnName("serag_shaqaaa");

                entity.Property(e => e.SeragidCountt).HasColumnName("seragid_countt");

                entity.Property(e => e.ShaqaaSeragCountt).HasColumnName("shaqaa_serag_countt");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.SuvBuildingnum)
                    .HasColumnType("character varying")
                    .HasColumnName("suv_buildingnum");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.Tawheed).HasColumnName("tawheed");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");
            });

            modelBuilder.Entity<SurveygisView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("surveygis_view2");

                entity.Property(e => e.ApartmentNo)
                    .HasMaxLength(10)
                    .HasColumnName("apartment_no");

                entity.Property(e => e.AreaBerElselm).HasColumnName("area_ber_elselm");

                entity.Property(e => e.AreaBuildings).HasColumnName("area_buildings");

                entity.Property(e => e.AreaMnawer).HasColumnName("area_mnawer");

                entity.Property(e => e.AttachName)
                    .HasColumnType("character varying")
                    .HasColumnName("attach_name");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.CorridorArea).HasColumnName("corridor_area");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EastBorderLength).HasColumnName("east_border_length");

                entity.Property(e => e.EastBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("east_border_name");

                entity.Property(e => e.ElevatorArea).HasColumnName("elevator_area");

                entity.Property(e => e.Gov)
                    .HasMaxLength(200)
                    .HasColumnName("gov");

                entity.Property(e => e.LandNo)
                    .HasColumnType("character varying")
                    .HasColumnName("land_no");

                entity.Property(e => e.LevelNo)
                    .HasMaxLength(20)
                    .HasColumnName("level_no");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.NorthBorderLength).HasColumnName("north_border_length");

                entity.Property(e => e.NorthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("north_border_name");

                entity.Property(e => e.Requestnumber)
                    .HasMaxLength(21)
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Sec)
                    .HasMaxLength(200)
                    .HasColumnName("sec");

                entity.Property(e => e.Serag)
                    .HasColumnType("character varying")
                    .HasColumnName("serag");

                entity.Property(e => e.SeragLetters)
                    .HasMaxLength(1)
                    .HasColumnName("serag_letters");

                entity.Property(e => e.SeragShaqaaa).HasColumnName("serag_shaqaaa");

                entity.Property(e => e.SeragidCountt).HasColumnName("seragid_countt");

                entity.Property(e => e.ShaqaaSeragCountt).HasColumnName("shaqaa_serag_countt");

                entity.Property(e => e.SouthBorderLength).HasColumnName("south_border_length");

                entity.Property(e => e.SouthBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("south_border_name");

                entity.Property(e => e.Streetname)
                    .HasMaxLength(200)
                    .HasColumnName("streetname");

                entity.Property(e => e.SurveyReviewStatus).HasColumnName("survey_review_status");

                entity.Property(e => e.SuvBuildingnum)
                    .HasColumnType("character varying")
                    .HasColumnName("suv_buildingnum");

                entity.Property(e => e.SuvSubtype).HasColumnName("suv_subtype");

                entity.Property(e => e.TankNo)
                    .HasColumnType("character varying")
                    .HasColumnName("tank_no");

                entity.Property(e => e.Tawheed).HasColumnName("tawheed");

                entity.Property(e => e.TotalAreaBuilding).HasColumnName("total_area_building");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");

                entity.Property(e => e.WestBorderLength).HasColumnName("west_border_length");

                entity.Property(e => e.WestBorderName)
                    .HasColumnType("character varying")
                    .HasColumnName("west_border_name");
            });

            modelBuilder.Entity<Surveyteam>(entity =>
            {
                entity.ToTable("surveyteams");

                entity.HasIndex(e => e.Id, "suv")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.GovId).HasColumnName("gov_id");

                entity.Property(e => e.MappuserId)
                    .HasColumnType("character varying")
                    .HasColumnName("mappuser_id");

                entity.Property(e => e.Regionid)
                    .HasColumnName("regionid")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SurveyteamComment>(entity =>
            {
                entity.ToTable("surveyteam_comments");

                entity.HasIndex(e => e.Requestnumber, "suv_comment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");
            });

            modelBuilder.Entity<SurveyteamListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("surveyteam_list_view");

                entity.Property(e => e.AssignmentsDone).HasColumnName("assignments_done");

                entity.Property(e => e.AssignmentsNotDone).HasColumnName("assignments_not_done");

                entity.Property(e => e.AssignmentsRemain).HasColumnName("assignments_remain");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.EmployeeCount).HasColumnName("employee_count");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.SurveyteamsId).HasColumnName("surveyteams_id");
            });

            modelBuilder.Entity<SurveyteamRegion>(entity =>
            {
                entity.ToTable("surveyteam_region");

                entity.HasIndex(e => e.Id, "suvregion")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GovId).HasColumnName("gov_id");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.TeamId).HasColumnName("team_id");
            });

            modelBuilder.Entity<SurveyteamViewCollected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("surveyteam_view_collected");

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.EmployeeCount).HasColumnName("employee_count");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MappuserId)
                    .HasColumnType("character varying")
                    .HasColumnName("mappuser_id");

                entity.Property(e => e.NotDone).HasColumnName("not_done");

                entity.Property(e => e.Unable).HasColumnName("unable");
            });

            modelBuilder.Entity<SurveyteamsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("surveyteams_view");

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Region)
                    .HasMaxLength(200)
                    .HasColumnName("region");

                entity.Property(e => e.Remain).HasColumnName("remain");
            });

            modelBuilder.Entity<Ta3delatComm>(entity =>
            {
                entity.ToTable("ta3delat_comm");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CmmantTime).HasColumnName("cmmant_time");

                entity.Property(e => e.Commant)
                    .HasColumnType("character varying")
                    .HasColumnName("commant");

                entity.Property(e => e.Commpany)
                    .HasColumnType("character varying")
                    .HasColumnName("commpany");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.UserName)
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<Techoffice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("techoffice");

                entity.Property(e => e.Accept).HasColumnName("accept");

                entity.Property(e => e.Acceptandnotprint).HasColumnName("acceptandnotprint");

                entity.Property(e => e.Collected).HasColumnName("collected");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Countrequestpricedifferences).HasColumnName("countrequestpricedifferences");

                entity.Property(e => e.Countshippingorders).HasColumnName("countshippingorders");

                entity.Property(e => e.Notcollected).HasColumnName("notcollected");

                entity.Property(e => e.Notshipped).HasColumnName("notshipped");

                entity.Property(e => e.Office).HasColumnName("office");

                entity.Property(e => e.OfficeRefused).HasColumnName("office_refused");

                entity.Property(e => e.Precentage).HasColumnName("precentage");

                entity.Property(e => e.Print).HasColumnName("print");

                entity.Property(e => e.Refused).HasColumnName("refused");

                entity.Property(e => e.Reviewsrequest).HasColumnName("reviewsrequest");

                entity.Property(e => e.Shipped).HasColumnName("shipped");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Taazer).HasColumnName("taazer");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<UnittypeValue>(entity =>
            {
                entity.ToTable("unittype_value");

                entity.HasIndex(e => e.Id, "unittype")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Unitname)
                    .HasColumnType("character varying")
                    .HasColumnName("unitname");
            });

            modelBuilder.Entity<UsageStatus>(entity =>
            {
                entity.ToTable("usage_status");

                entity.HasIndex(e => e.Id, "idin");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('lukp_sub_unit_type_id_seq'::regclass)");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.ToTable("user_log");

                entity.HasIndex(e => e.AppName, "appname");

                entity.HasIndex(e => e.ProcessId, "reqnum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppName)
                    .HasColumnType("character varying")
                    .HasColumnName("app_name");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Process)
                    .HasColumnType("character varying")
                    .HasColumnName("process");

                entity.Property(e => e.ProcessId).HasColumnName("process_id");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.UserName)
                    .HasColumnType("character varying")
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<Useraddress>(entity =>
            {
                entity.ToTable("useraddresses");

                entity.HasIndex(e => e.Districtid, "dis");

                entity.HasIndex(e => e.Userprofileid, "profileindex");

                entity.HasIndex(e => e.Regionid, "regionindex");

                entity.HasIndex(e => e.Id, "useraddresses_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.Districtid).HasColumnName("districtid");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Regionid).HasColumnName("regionid");

                entity.Property(e => e.Userprofileid).HasColumnName("userprofileid");
            });

            modelBuilder.Entity<Userprofile>(entity =>
            {
                entity.ToTable("userprofiles");

                entity.HasIndex(e => e.Userid, "useridindex");

                entity.HasIndex(e => e.Id, "userprofiles_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Description)
                    .HasColumnType("character varying")
                    .HasColumnName("description");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("modifieddate");

                entity.Property(e => e.Telephonenumber)
                    .HasColumnType("character varying")
                    .HasColumnName("telephonenumber");

                entity.Property(e => e.Telephonenumber2)
                    .HasColumnType("character varying")
                    .HasColumnName("telephonenumber2");

                entity.Property(e => e.Userid)
                    .HasColumnType("character varying")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<ValidationGehat>(entity =>
            {
                entity.ToTable("validation_gehat");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ValidationProfile>(entity =>
            {
                entity.ToTable("validation_profiles");

                entity.HasIndex(e => e.OrganizationNameId, "validation_profiles_organization_name_id_b08e3b4b");

                entity.HasIndex(e => e.RoleIdId, "validation_profiles_role_id_id_e7c179b6");

                entity.HasIndex(e => e.UserId, "validation_profiles_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OrganizationAddress)
                    .HasMaxLength(150)
                    .HasColumnName("organization_address");

                entity.Property(e => e.OrganizationNameId).HasColumnName("organization_name_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleIdId).HasColumnName("role_id_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserJob)
                    .HasMaxLength(150)
                    .HasColumnName("user_job");

                entity.HasOne(d => d.OrganizationName)
                    .WithMany(p => p.ValidationProfiles)
                    .HasForeignKey(d => d.OrganizationNameId)
                    .HasConstraintName("validation_profiles_organization_name_id_b08e3b4b_fk_validatio");

                entity.HasOne(d => d.RoleId)
                    .WithMany(p => p.ValidationProfiles)
                    .HasForeignKey(d => d.RoleIdId)
                    .HasConstraintName("validation_profiles_role_id_id_e7c179b6_fk_validation_roles_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.ValidationProfile)
                    .HasForeignKey<ValidationProfile>(d => d.UserId)
                    .HasConstraintName("validation_profiles_user_id_0de1e800_fk_auth_user_id");
            });

            modelBuilder.Entity<ValidationRole>(entity =>
            {
                entity.ToTable("validation_roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Zdifferencespricandtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zdifferencespricandtype");

                entity.Property(e => e.Arabicfullname)
                    .HasMaxLength(200)
                    .HasColumnName("arabicfullname");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.Orderstatuss).HasColumnName("orderstatuss");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Referencenumber)
                    .HasMaxLength(255)
                    .HasColumnName("referencenumber")
                    .IsFixedLength();

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Subunittype).HasColumnName("subunittype");

                entity.Property(e => e.Subunittypearea).HasColumnName("subunittypearea");

                entity.Property(e => e.Telephonenumber)
                    .HasColumnType("character varying")
                    .HasColumnName("telephonenumber");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Unittype).HasColumnName("unittype");
            });

            modelBuilder.Entity<ZpayShahin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zpay_shahin");

                entity.Property(e => e.Cert).HasColumnName("cert");

                entity.Property(e => e.Fin).HasColumnName("fin");

                entity.Property(e => e.FinDate).HasColumnName("fin_date");

                entity.Property(e => e.Paytime)
                    .HasColumnType("character varying")
                    .HasColumnName("paytime");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Referencenumb).HasColumnName("referencenumb");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Typetext)
                    .HasColumnType("character varying")
                    .HasColumnName("typetext");

                entity.Property(e => e.Unittype)
                    .HasColumnType("character varying")
                    .HasColumnName("unittype");
            });

            modelBuilder.Entity<Zshippingorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zshippingorders");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("addeddate");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CommentTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("comment_time");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.EditStatus).HasColumnName("edit_status");

                entity.Property(e => e.Editcertificateinformation)
                    .HasColumnType("character varying")
                    .HasColumnName("editcertificateinformation");

                entity.Property(e => e.Extracopiesprice).HasColumnName("extracopiesprice");

                entity.Property(e => e.IdShippingorder).HasColumnName("id_shippingorder");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Numberofcopies).HasColumnName("numberofcopies");

                entity.Property(e => e.Orderstatus).HasColumnName("orderstatus");

                entity.Property(e => e.OverlapStatus)
                    .HasColumnType("char")
                    .HasColumnName("overlap_status");

                entity.Property(e => e.OverlapStatuss).HasColumnName("overlap_statuss");

                entity.Property(e => e.Paidstatus).HasColumnName("paidstatus");

                entity.Property(e => e.PrintDate).HasColumnName("print_date");

                entity.Property(e => e.PrintStatus).HasColumnName("print_status");

                entity.Property(e => e.PrintStatuss).HasColumnName("print_statuss");

                entity.Property(e => e.Recert).HasColumnName("recert");

                entity.Property(e => e.Recertt).HasColumnName("recertt");

                entity.Property(e => e.RequestCount).HasColumnName("request_count");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Requestnumber)
                    .HasColumnType("character varying")
                    .HasColumnName("requestnumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusDate).HasColumnName("status_date");

                entity.Property(e => e.Statuss).HasColumnName("statuss");

                entity.Property(e => e.Tofedex).HasColumnName("tofedex");

                entity.Property(e => e.Unittype)
                    .HasMaxLength(50)
                    .HasColumnName("unittype");
            });

            modelBuilder.Entity<ZshippingordersCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zshippingorders_count");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Edits).HasColumnName("edits");

                entity.Property(e => e.Extra).HasColumnName("extra");

                entity.Property(e => e.Layout).HasColumnName("layout");

                entity.Property(e => e.NoImg).HasColumnName("no_img");

                entity.Property(e => e.NotSend).HasColumnName("not_send");

                entity.Property(e => e.ReviewAccept).HasColumnName("review_accept");

                entity.Property(e => e.ReviewDone).HasColumnName("review_done");

                entity.Property(e => e.Sent).HasColumnName("sent");
            });

            modelBuilder.Entity<ZshippingordersCountSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zshippingorders_count_sum");

                entity.Property(e => e.Edits).HasColumnName("edits");

                entity.Property(e => e.Extra).HasColumnName("extra");

                entity.Property(e => e.Layout).HasColumnName("layout");

                entity.Property(e => e.NoImg).HasColumnName("no_img");

                entity.Property(e => e.NotSend).HasColumnName("not_send");

                entity.Property(e => e.ReviewAccept).HasColumnName("review_accept");

                entity.Property(e => e.ReviewDone).HasColumnName("review_done");

                entity.Property(e => e.Sent).HasColumnName("sent");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.HasSequence("assignements_id_seq");

            modelBuilder.HasSequence<int>("company_gov_id_seq");

            modelBuilder.HasSequence("field_data_v2_seq_seq");

            modelBuilder.HasSequence("survey_review_comments_id_seq");

            modelBuilder.HasSequence("survey_review_msd_comments_id_seq");

            modelBuilder.HasSequence("surveyteam_comments_id_seq");

            modelBuilder.HasSequence("surveyteams_id_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
