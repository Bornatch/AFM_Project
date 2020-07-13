using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AFM_Project.Models
{
    public partial class SeilernContext : DbContext
    {
        public SeilernContext()
        {
        }

        public SeilernContext(DbContextOptions<SeilernContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountShares> AccountShares { get; set; }
        public virtual DbSet<AlgParams> AlgParams { get; set; }
        public virtual DbSet<AlgPhase> AlgPhase { get; set; }
        public virtual DbSet<Algorithm> Algorithm { get; set; }
        public virtual DbSet<BrokerExecuted> BrokerExecuted { get; set; }
        public virtual DbSet<BrokerToExecute> BrokerToExecute { get; set; }
        public virtual DbSet<Brokers> Brokers { get; set; }
        public virtual DbSet<ClaimUser> ClaimUser { get; set; }
        public virtual DbSet<CmetConditions> CmetConditions { get; set; }
        public virtual DbSet<CmetTracking> CmetTracking { get; set; }
        public virtual DbSet<CmetTrackingBuy> CmetTrackingBuy { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DividendHistory> DividendHistory { get; set; }
        public virtual DbSet<EodbrokerData> EodbrokerData { get; set; }
        public virtual DbSet<Eoddata> Eoddata { get; set; }
        public virtual DbSet<Eodindexes> Eodindexes { get; set; }
        public virtual DbSet<Eodpositions> Eodpositions { get; set; }
        public virtual DbSet<ExecutedOrders> ExecutedOrders { get; set; }
        public virtual DbSet<Fixpositions> Fixpositions { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<IndexMembers> IndexMembers { get; set; }
        public virtual DbSet<Indexes> Indexes { get; set; }
        public virtual DbSet<Industries> Industries { get; set; }
        public virtual DbSet<IndustriesSub> IndustriesSub { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Messengers> Messengers { get; set; }
        public virtual DbSet<Monitoring> Monitoring { get; set; }
        public virtual DbSet<MonitoringByBroker> MonitoringByBroker { get; set; }
        public virtual DbSet<MonitoringLog> MonitoringLog { get; set; }
        public virtual DbSet<NewTrade> NewTrade { get; set; }
        public virtual DbSet<NewTradebuy> NewTradebuy { get; set; }
        public virtual DbSet<NewTrades> NewTrades { get; set; }
        public virtual DbSet<OpenOrdersBrokerToExecute> OpenOrdersBrokerToExecute { get; set; }
        public virtual DbSet<Paiment> Paiment { get; set; }
        public virtual DbSet<ParamBatch> ParamBatch { get; set; }
        public virtual DbSet<ParamList> ParamList { get; set; }
        public virtual DbSet<ParamSetList> ParamSetList { get; set; }
        public virtual DbSet<ParamSingleValue> ParamSingleValue { get; set; }
        public virtual DbSet<Params> Params { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<PhaseType> PhaseType { get; set; }
        public virtual DbSet<PoolMembers> PoolMembers { get; set; }
        public virtual DbSet<Pools> Pools { get; set; }
        public virtual DbSet<PoolsAndPoolmembers> PoolsAndPoolmembers { get; set; }
        public virtual DbSet<Portfolio> Portfolio { get; set; }
        public virtual DbSet<PortfolioHistory> PortfolioHistory { get; set; }
        public virtual DbSet<Portfolios> Portfolios { get; set; }
        public virtual DbSet<QuoteImport> QuoteImport { get; set; }
        public virtual DbSet<Quotes> Quotes { get; set; }
        public virtual DbSet<Quotes1> Quotes1 { get; set; }
        public virtual DbSet<QuotesDaily> QuotesDaily { get; set; }
        public virtual DbSet<QuotesEvent> QuotesEvent { get; set; }
        public virtual DbSet<QuotesEventLog> QuotesEventLog { get; set; }
        public virtual DbSet<QuotesFromCybertrader> QuotesFromCybertrader { get; set; }
        public virtual DbSet<QuotesFromSchwab> QuotesFromSchwab { get; set; }
        public virtual DbSet<QuotesHistory> QuotesHistory { get; set; }
        public virtual DbSet<QuotesIndices> QuotesIndices { get; set; }
        public virtual DbSet<QuotesToExclude> QuotesToExclude { get; set; }
        public virtual DbSet<QuotesToMonitor> QuotesToMonitor { get; set; }
        public virtual DbSet<ReverseOrders> ReverseOrders { get; set; }
        public virtual DbSet<Rsq1history> Rsq1history { get; set; }
        public virtual DbSet<Secfees> Secfees { get; set; }
        public virtual DbSet<Sectors> Sectors { get; set; }
        public virtual DbSet<Securities> Securities { get; set; }
        public virtual DbSet<Seilernlog> Seilernlog { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SimSetup> SimSetup { get; set; }
        public virtual DbSet<SmartLimit> SmartLimit { get; set; }
        public virtual DbSet<Sp500> Sp500 { get; set; }
        public virtual DbSet<Symbols> Symbols { get; set; }
        public virtual DbSet<Traded2> Traded2 { get; set; }
        public virtual DbSet<TradedOrders> TradedOrders { get; set; }
        public virtual DbSet<Volatilities> Volatilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=BORNATCH-LENOVO\\SQLEXPRESS;Initial Catalog=Seilern;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountShares>(entity =>
            {
                entity.HasKey(e => e.IdAccountShares);

                entity.Property(e => e.IdAccountShares).HasColumnName("id_accountShares");

                entity.Property(e => e.BotSold).HasColumnName("bot_sold");

                entity.Property(e => e.CapitalIncrease).HasColumnName("capital_increase");

                entity.Property(e => e.CustomerIsBrokerData).HasColumnName("customer_isBrokerData");

                entity.Property(e => e.CustomerType).HasColumnName("customer_type");

                entity.Property(e => e.DateStamp)
                    .HasColumnName("dateStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.NbShares).HasColumnName("nb_shares");

                entity.Property(e => e.Portfolio).HasColumnName("portfolio");
            });

            modelBuilder.Entity<AlgParams>(entity =>
            {
                entity.HasKey(e => e.IdAlgparam);

                entity.Property(e => e.IdAlgparam).HasColumnName("id_algparam");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdPhaseOrAlgo).HasColumnName("id_PhaseOrAlgo");

                entity.Property(e => e.ParamBoolValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParamDoubleValue).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ParamIntValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParamName).HasMaxLength(50);

                entity.Property(e => e.ParamStringValue)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AlgPhase>(entity =>
            {
                entity.HasKey(e => new { e.IdAlgorithm, e.IdPhase });

                entity.Property(e => e.IdAlgorithm).HasColumnName("id_algorithm");

                entity.Property(e => e.IdPhase).HasColumnName("id_phase");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.Pos).HasColumnName("pos");
            });

            modelBuilder.Entity<Algorithm>(entity =>
            {
                entity.HasKey(e => e.IdAlgorithm);

                entity.Property(e => e.IdAlgorithm)
                    .HasColumnName("id_algorithm")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BrokerList).HasMaxLength(100);

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<BrokerExecuted>(entity =>
            {
                entity.HasKey(e => e.IdBrokerExecuted);

                entity.Property(e => e.IdBrokerExecuted).HasColumnName("id_BrokerExecuted");

                entity.Property(e => e.ActionPerformed).HasMaxLength(3);

                entity.Property(e => e.ApiorderId).HasColumnName("APIOrderId");

                entity.Property(e => e.Custom1).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.IbPermId).HasColumnName("IbPermID");

                entity.Property(e => e.IdBrokerToExecute).HasColumnName("id_BrokerToExecute");

                entity.Property(e => e.Security).HasMaxLength(12);
            });

            modelBuilder.Entity<BrokerToExecute>(entity =>
            {
                entity.HasKey(e => new { e.IdBrokerToExecute, e.ApiorderId });

                entity.HasIndex(e => new { e.Status, e.IdBrokerToExecute, e.Security, e.Quantity, e.Price, e.WhatAction, e.Exchange, e.ApiorderId, e.UserId })
                    .HasName("BrokerToExecute10");

                entity.Property(e => e.IdBrokerToExecute).HasColumnName("id_BrokerToExecute");

                entity.Property(e => e.ApiorderId)
                    .HasColumnName("APIOrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BrokerOrderId)
                    .HasColumnName("BrokerOrderID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.IbApiorderId).HasColumnName("IbAPIOrderID");

                entity.Property(e => e.IbPermId).HasColumnName("IbPermID");

                entity.Property(e => e.IdBroker).HasColumnName("id_broker");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_Order")
                    .HasComment("That could be a newtrade or a traded");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Security).HasMaxLength(12);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Brokers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdBroker).HasColumnName("id_broker");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ClaimUser>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK__ClaimUse__EF2E13BBD31FF733");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("ClaimID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimType).HasMaxLength(50);

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");
                
                
                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.ClaimUser)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("FK__ClaimUser__id_cu__7AF13DF7");
                
            });

            modelBuilder.Entity<CmetConditions>(entity =>
            {
                entity.HasKey(e => e.IdCmetConditions);

                entity.ToTable("CMet_conditions");

                entity.Property(e => e.IdCmetConditions)
                    .HasColumnName("Id_cmet_conditions")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExecSavings).HasColumnName("exec_savings");

                entity.Property(e => e.IdNewtrade).HasColumnName("id_newtrade");

                entity.Property(e => e.InitSavings).HasColumnName("init_savings");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateMaxSavings)
                    .HasColumnName("LastUpdate_MaxSavings")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxSavings).HasColumnName("max_savings");

                entity.Property(e => e.ReqSavings)
                    .HasColumnName("req_savings")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Sell).HasMaxLength(10);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StopDate)
                    .HasColumnName("Stop_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrailingSavings).HasColumnName("trailing_savings");
            });

            modelBuilder.Entity<CmetTracking>(entity =>
            {
                entity.HasKey(e => e.IdCmetTracking);

                entity.ToTable("CMet_tracking");

                entity.HasIndex(e => e.DateStamp)
                    .HasName("DateStamp DESC");

                entity.HasIndex(e => e.IdCmetConditions)
                    .HasName("id_cmet_conditions");

                entity.HasIndex(e => new { e.IdCmetConditions, e.DateStamp })
                    .HasName("CMet_tracking13");

                entity.Property(e => e.IdCmetTracking).HasColumnName("id_cmet_tracking");

                entity.Property(e => e.Bquote).HasColumnName("BQuote");

                entity.Property(e => e.Buy).HasMaxLength(10);

                entity.Property(e => e.CurSavings).HasColumnName("cur_savings");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.ExecSavings).HasColumnName("exec_savings");

                entity.Property(e => e.IdCmetConditions).HasColumnName("id_cmet_conditions");

                entity.Property(e => e.MeanPerf).HasColumnName("mean_perf");

                entity.Property(e => e.Sell).HasMaxLength(10);

                entity.Property(e => e.Squote).HasColumnName("SQuote");
            });

            modelBuilder.Entity<CmetTrackingBuy>(entity =>
            {
                entity.HasKey(e => e.IdCmetTrackingBuy);

                entity.ToTable("CMet_trackingBuy");

                entity.HasIndex(e => e.Buy)
                    .HasName("Buy");

                entity.HasIndex(e => e.IdCmetTracking)
                    .HasName("id_cmet_tracking");

                entity.Property(e => e.IdCmetTrackingBuy).HasColumnName("id_cmet_trackingBuy");

                entity.Property(e => e.Bquote).HasColumnName("BQuote");

                entity.Property(e => e.Buy).HasMaxLength(10);

                entity.Property(e => e.CurSavings).HasColumnName("cur_savings");

                entity.Property(e => e.IdCmetTracking).HasColumnName("id_cmet_tracking");

                entity.Property(e => e.MeanPerf)
                    .HasColumnName("mean_perf")
                    .HasDefaultValueSql("((0.0))");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer)
                    .HasName("Customer_PK");

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("Id_customer")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Account)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNick)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IdAlgorithmCheckauto).HasColumnName("id_algorithm_checkauto");

                entity.Property(e => e.IdAlgorithmFast).HasColumnName("id_algorithm_fast");

                entity.Property(e => e.IdAlgorithmSlow).HasColumnName("id_algorithm_slow");

                entity.Property(e => e.IdBroker).HasColumnName("id_broker");

                entity.Property(e => e.IdMetaCustomer)
                    .HasColumnName("id_MetaCustomer")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastLogin).HasColumnType("smalldatetime");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHint)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneBusiness)
                    .HasColumnName("Phone_business")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCell)
                    .HasColumnName("Phone_cell")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("Phone_fax")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasColumnName("Phone_home")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Postal)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PowerUser).HasDefaultValueSql("((0))");

                entity.Property(e => e.RegisterDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SecondMail)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ShareInfoOk)
                    .IsRequired()
                    .HasColumnName("ShareInfoOK")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartupPage).HasMaxLength(100);

                entity.Property(e => e.ThirdMail)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DividendHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ExDate)
                    .HasColumnName("ex_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdDividendHistory)
                    .HasColumnName("idDividendHistory")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValueAction).HasColumnName("value_action");

                entity.Property(e => e.ValueAll).HasColumnName("value_all");
            });

            modelBuilder.Entity<EodbrokerData>(entity =>
            {
                entity.ToTable("EODBrokerData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BotSold).HasColumnName("bot_sold");

                entity.Property(e => e.CapitalIncrease).HasColumnName("capital_increase");

                entity.Property(e => e.Datestamp)
                    .HasColumnName("datestamp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.NbShares).HasColumnName("nb_shares");

                entity.Property(e => e.PortfolioSharePrice).HasColumnName("portfolio_share_price");
            });

            modelBuilder.Entity<Eoddata>(entity =>
            {
                entity.ToTable("EODData");

                entity.HasIndex(e => e.DateStamp)
                    .HasName("EODData19");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BotSold)
                    .HasColumnName("bot_sold")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.CapitalIncrease)
                    .HasColumnName("capital_increase")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Cash).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.DateStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.NbShares)
                    .HasColumnName("nb_shares")
                    .HasDefaultValueSql("((0.0))");
            });

            modelBuilder.Entity<Eodindexes>(entity =>
            {
                entity.ToTable("EODIndexes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Compx).HasColumnName("COMPX");

                entity.Property(e => e.DateStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.Djia).HasColumnName("DJIA");

                entity.Property(e => e.Dtx).HasColumnName("DTX");

                entity.Property(e => e.Dux).HasColumnName("DUX");

                entity.Property(e => e.Ecm).HasColumnName("ECM");

                entity.Property(e => e.Rlx).HasColumnName("RLX");

                entity.Property(e => e.Rut).HasColumnName("RUT");

                entity.Property(e => e.Spx).HasColumnName("SPX");
            });

            modelBuilder.Entity<Eodpositions>(entity =>
            {
                entity.ToTable("EODPositions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.Security).HasMaxLength(10);
            });

            modelBuilder.Entity<ExecutedOrders>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Compx)
                    .HasColumnName("COMPX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Djia)
                    .HasColumnName("DJIA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecutionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IdBuyline).HasColumnName("Id_buyline");

                entity.Property(e => e.IdOrder).HasColumnName("Id_order");

                entity.Property(e => e.Spx)
                    .HasColumnName("SPX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Which)
                    .HasColumnName("which")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Fixpositions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BuyValue).HasColumnName("buy_value");

                entity.Property(e => e.Executed).HasColumnName("executed");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.ImportDate)
                    .HasColumnName("import_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Security).HasMaxLength(50);
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(e => e.IdHistory)
                    .HasName("History_PK");

                entity.Property(e => e.IdHistory)
                    .HasColumnName("Id_history")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseDate)
                    .HasColumnName("Close_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HolidayDate)
                    .HasColumnName("Holiday_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HolidayLabel)
                    .HasColumnName("Holiday_label")
                    .HasMaxLength(64);

                entity.Property(e => e.IdHolidays)
                    .HasColumnName("Id_holidays")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<IndexMembers>(entity =>
            {
                entity.HasKey(e => e.IdIndexmembers);

                entity.Property(e => e.IdIndexmembers).HasColumnName("id_indexmembers");

                entity.Property(e => e.IdIndex).HasColumnName("id_index");

                entity.Property(e => e.IdSecurity).HasColumnName("id_security");

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasMaxLength(20);

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Indexes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Abbrev)
                    .HasColumnName("abbrev")
                    .HasMaxLength(25);

                entity.Property(e => e.IdIndex).HasColumnName("id_index");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Ticker)
                    .HasColumnName("ticker")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Industries>(entity =>
            {
                entity.HasKey(e => e.IdIndustry);

                entity.Property(e => e.IdIndustry).HasColumnName("id_industry");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<IndustriesSub>(entity =>
            {
                entity.HasKey(e => e.IdSubindustry);

                entity.Property(e => e.IdSubindustry).HasColumnName("id_subindustry");

                entity.Property(e => e.IdIndustry).HasColumnName("id_industry");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Body).HasMaxLength(256);

                entity.Property(e => e.IdMessage)
                    .HasColumnName("Id_message")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Recipient).HasMaxLength(128);

                entity.Property(e => e.Sent).HasColumnType("datetime");
            });

            modelBuilder.Entity<Messengers>(entity =>
            {
                entity.HasKey(e => e.IdMessenger)
                    .HasName("Messengers_PK");

                entity.Property(e => e.IdMessenger)
                    .HasColumnName("Id_messenger")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.MessengerId)
                    .HasColumnName("MessengerID")
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Messengers)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("Customer_Messengers_FK1");
            });

            modelBuilder.Entity<Monitoring>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AlgoCheckAutoTs)
                    .HasColumnName("AlgoCheckAutoTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.AlgoFastTs)
                    .HasColumnName("AlgoFastTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.AlgoSlowTs)
                    .HasColumnName("AlgoSlowTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExecApilastMonitoring)
                    .HasColumnName("ExecAPILastMonitoring")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExecApimonitoringStatus).HasColumnName("ExecAPIMonitoringStatus");

                entity.Property(e => e.ExecApistatus).HasColumnName("ExecAPIStatus");

                entity.Property(e => e.MdiApistatus).HasColumnName("MdiAPIStatus");
            });

            modelBuilder.Entity<MonitoringByBroker>(entity =>
            {
                entity.HasKey(e => e.IdBroker);

                entity.Property(e => e.IdBroker)
                    .HasColumnName("id_broker")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExecApilastMonitoring)
                    .HasColumnName("ExecAPILastMonitoring")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExecApimonitoringStatus).HasColumnName("ExecAPIMonitoringStatus");

                entity.Property(e => e.ExecApistatus).HasColumnName("ExecAPIStatus");
            });

            modelBuilder.Entity<MonitoringLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Datestamp)
                    .HasColumnName("datestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdLog).HasColumnName("id_log");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasColumnType("text");

                entity.Property(e => e.MsgSubtype).HasColumnName("msgSubtype");

                entity.Property(e => e.MsgType).HasColumnName("msgType");

                entity.Property(e => e.Severity).HasColumnName("severity");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NewTrade>(entity =>
            {
                entity.HasKey(e => e.IdNewtrade)
                    .HasName("newTRADE_PK");

                entity.ToTable("newTRADE");

                entity.Property(e => e.IdNewtrade)
                    .HasColumnName("Id_newtrade")
                    .ValueGeneratedNever();

                entity.Property(e => e.Compx)
                    .HasColumnName("COMPX")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Djia)
                    .HasColumnName("DJIA")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.DoReverse)
                    .HasColumnName("doReverse")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdPool).HasColumnName("Id_pool");

                entity.Property(e => e.IdSeilern).HasColumnName("Id_seilern");

                entity.Property(e => e.NegSavL0time)
                    .HasColumnName("NegSavL0Time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NegSavingL0).HasDefaultValueSql("((0))");

                entity.Property(e => e.NegSavingL1).HasDefaultValueSql("((0))");

                entity.Property(e => e.NegSavingL2).HasDefaultValueSql("((0))");

                entity.Property(e => e.NegSavingL3).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Sell).HasMaxLength(64);

                entity.Property(e => e.Spx)
                    .HasColumnName("SPX")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Squantity).HasColumnName("SQuantity");

                entity.Property(e => e.Squote).HasColumnName("SQuote");

                entity.Property(e => e.StopLoss).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewTradebuy>(entity =>
            {
                entity.HasKey(e => e.IdNewtradebuy)
                    .HasName("newTRADEbuy_PK");

                entity.ToTable("newTRADEbuy");

                entity.Property(e => e.IdNewtradebuy)
                    .HasColumnName("Id_newtradebuy")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bquantity).HasColumnName("BQuantity");

                entity.Property(e => e.Bquote).HasColumnName("BQuote");

                entity.Property(e => e.Buy).HasMaxLength(64);

                entity.Property(e => e.CurSavingTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdNewtrade).HasColumnName("Id_newtrade");

                entity.Property(e => e.OldSavingTimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<NewTrades>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NewTrades");

                entity.Property(e => e.Compx).HasColumnName("COMPX");

                entity.Property(e => e.Djia).HasColumnName("DJIA");

                entity.Property(e => e.DoReverse).HasColumnName("doReverse");

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdNewtrade).HasColumnName("Id_newtrade");

                entity.Property(e => e.IdPool).HasColumnName("Id_pool");

                entity.Property(e => e.IdSeilern).HasColumnName("Id_seilern");

                entity.Property(e => e.NegSavL0time)
                    .HasColumnName("NegSavL0Time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Sell).HasMaxLength(64);

                entity.Property(e => e.Spx).HasColumnName("SPX");

                entity.Property(e => e.Squantity).HasColumnName("SQuantity");

                entity.Property(e => e.Squote).HasColumnName("SQuote");
            });

            modelBuilder.Entity<OpenOrdersBrokerToExecute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Open_Orders_Broker_to_Execute");

                entity.Property(e => e.ApiorderId)
                    .HasColumnName("APIOrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BrokerOrderId).HasColumnName("BrokerOrderID");

                entity.Property(e => e.IbApiorderId).HasColumnName("IbAPIOrderID");

                entity.Property(e => e.IbPermId).HasColumnName("IbPermID");

                entity.Property(e => e.IdBroker).HasColumnName("id_broker");

                entity.Property(e => e.IdBrokerToExecute).HasColumnName("id_BrokerToExecute");

                entity.Property(e => e.IdOrder).HasColumnName("id_Order");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Security).HasMaxLength(12);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Paiment>(entity =>
            {
                entity.HasKey(e => e.IdPaiment)
                    .HasName("Paiment_PK");

                entity.Property(e => e.IdPaiment)
                    .HasColumnName("Id_paiment")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardExpiration)
                    .HasColumnName("Card_expiration")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CardNumber)
                    .HasColumnName("Card_number")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DatePaiment)
                    .HasColumnName("Date_paiment")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");
            });

            modelBuilder.Entity<ParamBatch>(entity =>
            {
                entity.HasKey(e => e.IdBatch);

                entity.ToTable("Param_batch");

                entity.Property(e => e.IdBatch).HasColumnName("id_batch");

                entity.Property(e => e.CountCombinations).HasColumnName("count_combinations");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurCombination).HasColumnName("cur_combination");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ParamList>(entity =>
            {
                entity.HasKey(e => e.IdParamList);

                entity.ToTable("Param_list");

                entity.Property(e => e.IdParamList).HasColumnName("id_param_list");

                entity.Property(e => e.CountPos).HasColumnName("count_pos");

                entity.Property(e => e.CurPos).HasColumnName("cur_pos");

                entity.Property(e => e.IdParamSinglevalue).HasColumnName("id_param_singlevalue");

                entity.Property(e => e.MaxValue).HasColumnName("max_value");

                entity.Property(e => e.MinValue).HasColumnName("min_value");

                entity.Property(e => e.StepValue).HasColumnName("step_value");

                entity.Property(e => e.TypeEnum).HasColumnName("type_enum");

                entity.Property(e => e.ValuesList)
                    .HasColumnName("values_list")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ParamSetList>(entity =>
            {
                entity.HasKey(e => e.IdParamSetList);

                entity.ToTable("Param_set_list");

                entity.Property(e => e.IdParamSetList).HasColumnName("id_param_set_list");

                entity.Property(e => e.IdBatch).HasColumnName("id_batch");

                entity.Property(e => e.IdParamList).HasColumnName("id_param_list");

                entity.Property(e => e.ParamOrder).HasColumnName("Param_order");
            });

            modelBuilder.Entity<ParamSingleValue>(entity =>
            {
                entity.HasKey(e => e.IdParamSinglevalue);

                entity.ToTable("Param_singleValue");

                entity.Property(e => e.IdParamSinglevalue).HasColumnName("id_param_singlevalue");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdParam).HasColumnName("id_param");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ValueBool).HasColumnName("value_bool");

                entity.Property(e => e.ValueDouble).HasColumnName("value_double");

                entity.Property(e => e.ValueInt).HasColumnName("value_int");

                entity.Property(e => e.ValueString)
                    .HasColumnName("value_string")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Params>(entity =>
            {
                entity.HasKey(e => e.IdParam);

                entity.Property(e => e.IdParam).HasColumnName("id_param");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("ntext");

                entity.Property(e => e.IdAttach).HasColumnName("id_attach");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(25);

                entity.Property(e => e.TypeAttach).HasColumnName("type_attach");

                entity.Property(e => e.TypeValue)
                    .HasColumnName("type_value")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.HasKey(e => e.IdPhase);

                entity.Property(e => e.IdPhase)
                    .HasColumnName("id_phase")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.IdPhasetype).HasColumnName("id_phasetype");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<PhaseType>(entity =>
            {
                entity.HasKey(e => e.IdPhasetype);

                entity.Property(e => e.IdPhasetype)
                    .HasColumnName("id_phasetype")
                    .ValueGeneratedNever();

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<PoolMembers>(entity =>
            {
                entity.HasKey(e => e.IdPoolMember);

                entity.HasIndex(e => e.Status)
                    .HasName("PoolMembers20");

                entity.Property(e => e.IdPoolMember)
                    .HasColumnName("Id_PoolMember")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.IdPool).HasColumnName("Id_pool");

                entity.Property(e => e.IsInitial).HasColumnName("Is_initial");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Security).HasMaxLength(10);
            });

            modelBuilder.Entity<Pools>(entity =>
            {
                entity.HasKey(e => e.IdPool);

                entity.Property(e => e.IdPool)
                    .HasColumnName("Id_pool")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateStopped).HasColumnType("datetime");

                entity.Property(e => e.ExtraValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdSector).HasColumnName("Id_sector");

                entity.Property(e => e.LastUpdatePool).HasColumnType("datetime");

                entity.Property(e => e.PerfRsq1).HasColumnName("PerfRSQ1");

                entity.Property(e => e.ReqSavings).HasColumnName("Req_savings");

                entity.Property(e => e.TaxesRsq1).HasColumnName("TaxesRSQ1");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<PoolsAndPoolmembers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Pools_and_poolmembers");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateStopped).HasColumnType("datetime");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdPool).HasColumnName("Id_pool");

                entity.Property(e => e.IsInitial).HasColumnName("Is_initial");

                entity.Property(e => e.PoolmembersStatus).HasColumnName("Poolmembers_Status");

                entity.Property(e => e.ReqSavings).HasColumnName("Req_savings");

                entity.Property(e => e.Security).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.HasIndex(e => new { e.IdCustomer, e.PortfolioNo, e.Security, e.Quantity, e.IdPortfolio, e.Name, e.PurchasedQuote, e.PurchasedWhen, e.IdTraded })
                    .HasName("Portfolio3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdPortfolio)
                    .HasColumnName("id_portfolio")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IdTraded).HasColumnName("Id_traded");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.PortfolioNo).HasColumnName("portfolio_no");

                entity.Property(e => e.PurchasedWhen).HasColumnType("datetime");

                entity.Property(e => e.Security).HasMaxLength(10);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Portfolio)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Portfolio_Customer");
            });

            modelBuilder.Entity<PortfolioHistory>(entity =>
            {
                entity.HasKey(e => e.IdHistory);

                entity.HasIndex(e => new { e.IdCustomer, e.DateTime, e.CurPortfolioTotal, e.CurPortfolioCash })
                    .HasName("PortfolioHistory15");

                entity.Property(e => e.IdHistory).HasColumnName("id_history");

                entity.Property(e => e.CurCompx).HasColumnName("CurCOMPX");

                entity.Property(e => e.CurDow).HasColumnName("CurDOW");

                entity.Property(e => e.CurSpx).HasColumnName("CurSPX");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.InitPortfolioTotal).HasDefaultValueSql("((0.0))");
            });

            modelBuilder.Entity<Portfolios>(entity =>
            {
                entity.HasKey(e => e.IdPortfolioNo);

                entity.Property(e => e.IdPortfolioNo).HasColumnName("Id_portfolio_no");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<QuoteImport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Datet)
                    .HasColumnName("datet")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Spx).HasColumnName("spx");
            });

            modelBuilder.Entity<Quotes>(entity =>
            {
                entity.HasKey(e => e.IdQuote);

                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code");

                entity.Property(e => e.IdQuote).HasColumnName("Id_quote");

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Quotes1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Quotes 1");

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.IdQuote).HasColumnName("Id_quote");

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotesDaily>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.IdQuote)
                    .HasColumnName("id_quote")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotesEvent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Security).HasMaxLength(10);
            });

            modelBuilder.Entity<QuotesEventLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<QuotesFromCybertrader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Quotes from Cybertrader");

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.IdQuote).HasColumnName("Id_quote");

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotesFromSchwab>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Quotes from Schwab");

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.IdQuote).HasColumnName("Id_quote");

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotesHistory>(entity =>
            {
                entity.HasIndex(e => e.Batchno)
                    .HasName("batchno");

                entity.HasIndex(e => new { e.QuoteDateTime, e.Security })
                    .HasName("QuoteDateTime_Security");

                entity.HasIndex(e => new { e.Security, e.QuoteDateTime })
                    .HasName("Security_QuoteDateTime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ask).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Batchno).HasColumnName("batchno");

                entity.Property(e => e.Bid).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.LastTrade).HasDefaultValueSql("((0.0))");

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");

                entity.Property(e => e.Security)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<QuotesIndices>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Quotes_indices");

                entity.Property(e => e.Code).HasMaxLength(12);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.IdQuote)
                    .HasColumnName("Id_quote")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.QuoteDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotesToExclude>(entity =>
            {
                entity.HasKey(e => e.Security);

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasMaxLength(10);

                entity.Property(e => e.DateTs)
                    .HasColumnName("dateTS")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<QuotesToMonitor>(entity =>
            {
                entity.HasKey(e => e.IdQtm);

                entity.Property(e => e.IdQtm).HasColumnName("id_qtm");

                entity.Property(e => e.Security)
                    .HasColumnName("security")
                    .HasMaxLength(10);

                entity.Property(e => e.Tsadded)
                    .HasColumnName("TSAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ReverseOrders>(entity =>
            {
                entity.HasKey(e => new { e.ParentId, e.ChildId });

                entity.Property(e => e.ParentId).HasColumnName("parentID");

                entity.Property(e => e.ChildId).HasColumnName("childID");
            });

            modelBuilder.Entity<Rsq1history>(entity =>
            {
                entity.HasKey(e => e.IdRsq1)
                    .HasName("PK_RSQ1");

                entity.ToTable("RSQ1History");

                entity.Property(e => e.IdRsq1)
                    .HasColumnName("Id_rsq1")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdPool).HasColumnName("Id_pool");

                entity.Property(e => e.PerfRsq1).HasColumnName("PerfRSQ1");

                entity.Property(e => e.TaxesRsq1).HasColumnName("TaxesRSQ1");
            });

            modelBuilder.Entity<Secfees>(entity =>
            {
                entity.HasKey(e => e.IdSecfees);

                entity.ToTable("SECFees");

                entity.Property(e => e.IdSecfees)
                    .HasColumnName("id_secfees")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fee).HasColumnName("fee");
            });

            modelBuilder.Entity<Sectors>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdSector)
                    .HasColumnName("id_sector")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Securities>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.IdIndustry).HasColumnName("id_industry");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.IdSecurity)
                    .HasColumnName("id_security")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdSubindustry).HasColumnName("id_subindustry");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Security).HasMaxLength(10);
            });

            modelBuilder.Entity<Seilernlog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdSeilernlog)
                    .HasColumnName("Id_seilernlog")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Logdate).HasColumnType("smalldatetime");

                entity.Property(e => e.Message).HasMaxLength(1024);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CheckCmetInterval)
                    .HasColumnName("CheckCmet_interval")
                    .HasComment("In seconds");

                entity.Property(e => e.EodStarthour).HasColumnName("EOD_Starthour");

                entity.Property(e => e.OrderScanInterval)
                    .HasColumnName("OrderScan_interval")
                    .HasComment("In seconds");

                entity.Property(e => e.SodStarthour)
                    .HasColumnName("SOD_Starthour")
                    .HasComment("Time of the day to switch");
            });

            modelBuilder.Entity<SimSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sim_setup");

                entity.Property(e => e.IdAlgoP1).HasColumnName("id_algoP1");

                entity.Property(e => e.IdAlgoP2).HasColumnName("id_algoP2");

                entity.Property(e => e.IdBatch).HasColumnName("id_batch");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");
            });

            modelBuilder.Entity<SmartLimit>(entity =>
            {
                entity.HasKey(e => e.IdSmartlimit)
                    .HasName("smartLIMIT_PK");

                entity.ToTable("smartLIMIT");

                entity.Property(e => e.IdSmartlimit)
                    .HasColumnName("Id_smartlimit")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurSavingTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdSeilern).HasColumnName("Id_seilern");

                entity.Property(e => e.Index)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.SmartLimit)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("Customer_smartLIMIT_FK1");
            });

            modelBuilder.Entity<Sp500>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SP500");

                entity.Property(e => e.Beta).HasColumnName("beta");

                entity.Property(e => e.GicsSector)
                    .HasColumnName("gics_sector")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GicsSubsector)
                    .HasColumnName("gics_subsector")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MarketCap).HasColumnName("market_cap");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Symbol)
                    .HasColumnName("symbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Symbols>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code).HasMaxLength(16);

                entity.Property(e => e.IdSymbol)
                    .HasColumnName("Id_symbol")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Traded2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Traded2");

                entity.Property(e => e.Bquantity).HasColumnName("BQuantity");

                entity.Property(e => e.Bquote).HasColumnName("BQuote");

                entity.Property(e => e.Buy).HasMaxLength(10);

                entity.Property(e => e.Compx).HasColumnName("COMPX");

                entity.Property(e => e.Djia).HasColumnName("DJIA");

                entity.Property(e => e.IdBuyline).HasColumnName("id_buyline");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdNtslmc).HasColumnName("id_NTSLMC");

                entity.Property(e => e.IdTraded).HasColumnName("id_traded");

                entity.Property(e => e.PortfolioNo).HasColumnName("Portfolio_no");

                entity.Property(e => e.Seccommission).HasColumnName("SECCommission");

                entity.Property(e => e.Sell).HasMaxLength(10);

                entity.Property(e => e.Spx).HasColumnName("SPX");

                entity.Property(e => e.Squantity).HasColumnName("SQuantity");

                entity.Property(e => e.Squote).HasColumnName("SQuote");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TradedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TradedOrders>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.IdTraded)
                    .HasName("TradedOrders1")
                    .IsClustered();

                entity.HasIndex(e => new { e.TradedDate, e.IdCustomer, e.Buy, e.Ordertype })
                    .HasName("TradedOrders13");

                entity.Property(e => e.Bquantity).HasColumnName("BQuantity");

                entity.Property(e => e.Bquote).HasColumnName("BQuote");

                entity.Property(e => e.Buy).HasMaxLength(10);

                entity.Property(e => e.Compx)
                    .HasColumnName("COMPX")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Djia)
                    .HasColumnName("DJIA")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Executor).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdBuyline).HasColumnName("id_buyline");

                entity.Property(e => e.IdCustomer).HasColumnName("Id_customer");

                entity.Property(e => e.IdNtslmc).HasColumnName("id_NTSLMC");

                entity.Property(e => e.IdTraded)
                    .HasColumnName("id_traded")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PortfolioNo).HasColumnName("Portfolio_no");

                entity.Property(e => e.Seccommission).HasColumnName("SECCommission");

                entity.Property(e => e.Sell).HasMaxLength(10);

                entity.Property(e => e.Spx)
                    .HasColumnName("SPX")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Squantity).HasColumnName("SQuantity");

                entity.Property(e => e.Squote).HasColumnName("SQuote");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TradedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Volatilities>(entity =>
            {
                entity.HasKey(e => e.IdVolatility)
                    .HasName("Volatilities_PK");

                entity.Property(e => e.IdVolatility)
                    .HasColumnName("Id_volatility")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseDate)
                    .HasColumnName("Close_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
