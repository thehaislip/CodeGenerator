using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Security.Principal;
using System.Security.Principal;
using System.Security.Claims; 
namespace GeneratedContext
{ 
[Table("ScoreLinkData")]
public partial class ScoreLinkData
:IAuditable{ 
public ScoreLinkData()
{
this.OCETSPraxisTests = new HashSet<OCETSPraxisTest>();
}
[Column(name:"Address")]
[StringLength(30)]
public string Address {get; set;}
[Column(name:"AttendInst")]
[StringLength(4)]
public string AttendInst {get; set;}
[Required]
[Column(name:"BirthDate")]
[StringLength(10)]
public string BirthDate {get; set;}
[Column(name:"CandidateIDNumber")]
[StringLength(8)]
public string CandidateIDNumber {get; set;}
[Column(name:"City")]
[StringLength(14)]
public string City {get; set;}
[Column(name:"CountryCode")]
[StringLength(3)]
public string CountryCode {get; set;}
[Column(name:"CreationDate")]
[StringLength(8)]
public string CreationDate {get; set;}
[Column(name:"CurrTest1Code")]
[StringLength(4)]
public string CurrTest1Code {get; set;}
[Column(name:"CurrTest1Date")]
[StringLength(8)]
public string CurrTest1Date {get; set;}
[Column(name:"CurrTest1Filler")]
[StringLength(1)]
public string CurrTest1Filler {get; set;}
[Column(name:"CurrTest1NonStandAdmin")]
[StringLength(1)]
public string CurrTest1NonStandAdmin {get; set;}
[Column(name:"CurrTest1ROE")]
[StringLength(1)]
public string CurrTest1ROE {get; set;}
[Column(name:"CurrTest1Score")]
[StringLength(3)]
public string CurrTest1Score {get; set;}
[Column(name:"CurrTest2Code")]
[StringLength(4)]
public string CurrTest2Code {get; set;}
[Column(name:"CurrTest2Date")]
[StringLength(8)]
public string CurrTest2Date {get; set;}
[Column(name:"CurrTest2Filler")]
[StringLength(1)]
public string CurrTest2Filler {get; set;}
[Column(name:"CurrTest2NonStandAdmin")]
[StringLength(1)]
public string CurrTest2NonStandAdmin {get; set;}
[Column(name:"CurrTest2ROE")]
[StringLength(1)]
public string CurrTest2ROE {get; set;}
[Column(name:"CurrTest2Score")]
[StringLength(3)]
public string CurrTest2Score {get; set;}
[Column(name:"CurrTest3Code")]
[StringLength(4)]
public string CurrTest3Code {get; set;}
[Column(name:"CurrTest3Date")]
[StringLength(8)]
public string CurrTest3Date {get; set;}
[Column(name:"CurrTest3Filler")]
[StringLength(1)]
public string CurrTest3Filler {get; set;}
[Column(name:"CurrTest3NonStandAdmin")]
[StringLength(1)]
public string CurrTest3NonStandAdmin {get; set;}
[Column(name:"CurrTest3ROE")]
[StringLength(1)]
public string CurrTest3ROE {get; set;}
[Column(name:"CurrTest3Score")]
[StringLength(3)]
public string CurrTest3Score {get; set;}
[Column(name:"CurrTest4Code")]
[StringLength(4)]
public string CurrTest4Code {get; set;}
[Column(name:"CurrTest4Date")]
[StringLength(8)]
public string CurrTest4Date {get; set;}
[Column(name:"CurrTest4Filler")]
[StringLength(1)]
public string CurrTest4Filler {get; set;}
[Column(name:"CurrTest4NonStandAdmin")]
[StringLength(1)]
public string CurrTest4NonStandAdmin {get; set;}
[Column(name:"CurrTest4ROE")]
[StringLength(1)]
public string CurrTest4ROE {get; set;}
[Column(name:"CurrTest4Score")]
[StringLength(3)]
public string CurrTest4Score {get; set;}
[Column(name:"CurrTest5Code")]
[StringLength(4)]
public string CurrTest5Code {get; set;}
[Column(name:"CurrTest5Date")]
[StringLength(8)]
public string CurrTest5Date {get; set;}
[Column(name:"CurrTest5Filler")]
[StringLength(1)]
public string CurrTest5Filler {get; set;}
[Column(name:"CurrTest5NonStandAdmin")]
[StringLength(1)]
public string CurrTest5NonStandAdmin {get; set;}
[Column(name:"CurrTest5ROE")]
[StringLength(1)]
public string CurrTest5ROE {get; set;}
[Column(name:"CurrTest5Score")]
[StringLength(3)]
public string CurrTest5Score {get; set;}
[Column(name:"CurrTest6Code")]
[StringLength(4)]
public string CurrTest6Code {get; set;}
[Column(name:"CurrTest6Date")]
[StringLength(8)]
public string CurrTest6Date {get; set;}
[Column(name:"CurrTest6Filler")]
[StringLength(1)]
public string CurrTest6Filler {get; set;}
[Column(name:"CurrTest6NonStandAdmin")]
[StringLength(1)]
public string CurrTest6NonStandAdmin {get; set;}
[Column(name:"CurrTest6ROE")]
[StringLength(1)]
public string CurrTest6ROE {get; set;}
[Column(name:"CurrTest6Score")]
[StringLength(3)]
public string CurrTest6Score {get; set;}
[Column(name:"DateRecvd",TypeName = "datetime2")]
public DateTime? DateRecvd {get; set;}
[Column(name:"EducationLevel")]
[StringLength(3)]
public string EducationLevel {get; set;}
[Column(name:"EthnicityCode")]
[StringLength(3)]
public string EthnicityCode {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(10)]
public string FirstName {get; set;}
[Column(name:"GradMajor")]
[StringLength(3)]
public string GradMajor {get; set;}
[Column(name:"HiScoreTest10Code")]
[StringLength(4)]
public string HiScoreTest10Code {get; set;}
[Column(name:"HiScoreTest10Date")]
[StringLength(8)]
public string HiScoreTest10Date {get; set;}
[Column(name:"HiScoreTest10NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest10NonStandAdmin {get; set;}
[Column(name:"HiScoreTest10ROE")]
[StringLength(1)]
public string HiScoreTest10ROE {get; set;}
[Column(name:"HiScoreTest10RSI")]
[StringLength(1)]
public string HiScoreTest10RSI {get; set;}
[Column(name:"HiScoreTest10Score")]
[StringLength(3)]
public string HiScoreTest10Score {get; set;}
[Column(name:"HiScoreTest1Code")]
[StringLength(4)]
public string HiScoreTest1Code {get; set;}
[Column(name:"HiScoreTest1Date")]
[StringLength(8)]
public string HiScoreTest1Date {get; set;}
[Column(name:"HiScoreTest1NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest1NonStandAdmin {get; set;}
[Column(name:"HiScoreTest1ROE")]
[StringLength(1)]
public string HiScoreTest1ROE {get; set;}
[Column(name:"HiScoreTest1RSI")]
[StringLength(1)]
public string HiScoreTest1RSI {get; set;}
[Column(name:"HiScoreTest1Score")]
[StringLength(3)]
public string HiScoreTest1Score {get; set;}
[Column(name:"HiScoreTest2Code")]
[StringLength(4)]
public string HiScoreTest2Code {get; set;}
[Column(name:"HiScoreTest2Date")]
[StringLength(8)]
public string HiScoreTest2Date {get; set;}
[Column(name:"HiScoreTest2NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest2NonStandAdmin {get; set;}
[Column(name:"HiScoreTest2ROE")]
[StringLength(1)]
public string HiScoreTest2ROE {get; set;}
[Column(name:"HiScoreTest2RSI")]
[StringLength(1)]
public string HiScoreTest2RSI {get; set;}
[Column(name:"HiScoreTest2Score")]
[StringLength(3)]
public string HiScoreTest2Score {get; set;}
[Column(name:"HiScoreTest3Code")]
[StringLength(4)]
public string HiScoreTest3Code {get; set;}
[Column(name:"HiScoreTest3Date")]
[StringLength(8)]
public string HiScoreTest3Date {get; set;}
[Column(name:"HiScoreTest3NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest3NonStandAdmin {get; set;}
[Column(name:"HiScoreTest3ROE")]
[StringLength(1)]
public string HiScoreTest3ROE {get; set;}
[Column(name:"HiScoreTest3RSI")]
[StringLength(1)]
public string HiScoreTest3RSI {get; set;}
[Column(name:"HiScoreTest3Score")]
[StringLength(3)]
public string HiScoreTest3Score {get; set;}
[Column(name:"HiScoreTest4Code")]
[StringLength(4)]
public string HiScoreTest4Code {get; set;}
[Column(name:"HiScoreTest4Date")]
[StringLength(8)]
public string HiScoreTest4Date {get; set;}
[Column(name:"HiScoreTest4NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest4NonStandAdmin {get; set;}
[Column(name:"HiScoreTest4ROE")]
[StringLength(1)]
public string HiScoreTest4ROE {get; set;}
[Column(name:"HiScoreTest4RSI")]
[StringLength(1)]
public string HiScoreTest4RSI {get; set;}
[Column(name:"HiScoreTest4Score")]
[StringLength(3)]
public string HiScoreTest4Score {get; set;}
[Column(name:"HiScoreTest5Code")]
[StringLength(4)]
public string HiScoreTest5Code {get; set;}
[Column(name:"HiScoreTest5Date")]
[StringLength(8)]
public string HiScoreTest5Date {get; set;}
[Column(name:"HiScoreTest5NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest5NonStandAdmin {get; set;}
[Column(name:"HiScoreTest5ROE")]
[StringLength(1)]
public string HiScoreTest5ROE {get; set;}
[Column(name:"HiScoreTest5RSI")]
[StringLength(1)]
public string HiScoreTest5RSI {get; set;}
[Column(name:"HiScoreTest5Score")]
[StringLength(3)]
public string HiScoreTest5Score {get; set;}
[Column(name:"HiScoreTest6Code")]
[StringLength(4)]
public string HiScoreTest6Code {get; set;}
[Column(name:"HiScoreTest6Date")]
[StringLength(8)]
public string HiScoreTest6Date {get; set;}
[Column(name:"HiScoreTest6NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest6NonStandAdmin {get; set;}
[Column(name:"HiScoreTest6ROE")]
[StringLength(1)]
public string HiScoreTest6ROE {get; set;}
[Column(name:"HiScoreTest6RSI")]
[StringLength(1)]
public string HiScoreTest6RSI {get; set;}
[Column(name:"HiScoreTest6Score")]
[StringLength(3)]
public string HiScoreTest6Score {get; set;}
[Column(name:"HiScoreTest7Code")]
[StringLength(4)]
public string HiScoreTest7Code {get; set;}
[Column(name:"HiScoreTest7Date")]
[StringLength(8)]
public string HiScoreTest7Date {get; set;}
[Column(name:"HiScoreTest7NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest7NonStandAdmin {get; set;}
[Column(name:"HiScoreTest7ROE")]
[StringLength(1)]
public string HiScoreTest7ROE {get; set;}
[Column(name:"HiScoreTest7RSI")]
[StringLength(1)]
public string HiScoreTest7RSI {get; set;}
[Column(name:"HiScoreTest7Score")]
[StringLength(3)]
public string HiScoreTest7Score {get; set;}
[Column(name:"HiScoreTest8Code")]
[StringLength(4)]
public string HiScoreTest8Code {get; set;}
[Column(name:"HiScoreTest8Date")]
[StringLength(8)]
public string HiScoreTest8Date {get; set;}
[Column(name:"HiScoreTest8NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest8NonStandAdmin {get; set;}
[Column(name:"HiScoreTest8ROE")]
[StringLength(1)]
public string HiScoreTest8ROE {get; set;}
[Column(name:"HiScoreTest8RSI")]
[StringLength(1)]
public string HiScoreTest8RSI {get; set;}
[Column(name:"HiScoreTest8Score")]
[StringLength(3)]
public string HiScoreTest8Score {get; set;}
[Column(name:"HiScoreTest9Code")]
[StringLength(4)]
public string HiScoreTest9Code {get; set;}
[Column(name:"HiScoreTest9Date")]
[StringLength(8)]
public string HiScoreTest9Date {get; set;}
[Column(name:"HiScoreTest9NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest9NonStandAdmin {get; set;}
[Column(name:"HiScoreTest9ROE")]
[StringLength(1)]
public string HiScoreTest9ROE {get; set;}
[Column(name:"HiScoreTest9RSI")]
[StringLength(1)]
public string HiScoreTest9RSI {get; set;}
[Column(name:"HiScoreTest9Score")]
[StringLength(3)]
public string HiScoreTest9Score {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(15)]
public string LastName {get; set;}
[Column(name:"LowValueFiller")]
[StringLength(6)]
public string LowValueFiller {get; set;}
[Column(name:"MiddleInitial")]
[StringLength(1)]
public string MiddleInitial {get; set;}
[Column(name:"PassNPTest10HiScoreCode")]
[StringLength(4)]
public string PassNPTest10HiScoreCode {get; set;}
[Column(name:"PassNPTest10HiScoreDate")]
[StringLength(10)]
public string PassNPTest10HiScoreDate {get; set;}
[Column(name:"PassNPTest10HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest10HiScoreMetNM {get; set;}
[Column(name:"PassNPTest10HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest10HiScorePassedNP {get; set;}
[Column(name:"PassNPTest10HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest10HiScoreReqMin {get; set;}
[Column(name:"PassNPTest10HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest10HiScoreReqPass {get; set;}
[Column(name:"PassNPTest10HiScoreScore")]
[StringLength(4)]
public string PassNPTest10HiScoreScore {get; set;}
[Column(name:"PassNPTest11HiScoreCode")]
[StringLength(4)]
public string PassNPTest11HiScoreCode {get; set;}
[Column(name:"PassNPTest11HiScoreDate")]
[StringLength(10)]
public string PassNPTest11HiScoreDate {get; set;}
[Column(name:"PassNPTest11HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest11HiScoreMetNM {get; set;}
[Column(name:"PassNPTest11HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest11HiScorePassedNP {get; set;}
[Column(name:"PassNPTest11HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest11HiScoreReqMin {get; set;}
[Column(name:"PassNPTest11HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest11HiScoreReqPass {get; set;}
[Column(name:"PassNPTest11HiScoreScore")]
[StringLength(4)]
public string PassNPTest11HiScoreScore {get; set;}
[Column(name:"PassNPTest12HiScoreCode")]
[StringLength(4)]
public string PassNPTest12HiScoreCode {get; set;}
[Column(name:"PassNPTest12HiScoreDate")]
[StringLength(10)]
public string PassNPTest12HiScoreDate {get; set;}
[Column(name:"PassNPTest12HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest12HiScoreMetNM {get; set;}
[Column(name:"PassNPTest12HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest12HiScorePassedNP {get; set;}
[Column(name:"PassNPTest12HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest12HiScoreReqMin {get; set;}
[Column(name:"PassNPTest12HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest12HiScoreReqPass {get; set;}
[Column(name:"PassNPTest12HiScoreScore")]
[StringLength(4)]
public string PassNPTest12HiScoreScore {get; set;}
[Column(name:"PassNPTest13HiScoreCode")]
[StringLength(4)]
public string PassNPTest13HiScoreCode {get; set;}
[Column(name:"PassNPTest13HiScoreDate")]
[StringLength(10)]
public string PassNPTest13HiScoreDate {get; set;}
[Column(name:"PassNPTest13HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest13HiScoreMetNM {get; set;}
[Column(name:"PassNPTest13HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest13HiScorePassedNP {get; set;}
[Column(name:"PassNPTest13HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest13HiScoreReqMin {get; set;}
[Column(name:"PassNPTest13HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest13HiScoreReqPass {get; set;}
[Column(name:"PassNPTest13HiScoreScore")]
[StringLength(4)]
public string PassNPTest13HiScoreScore {get; set;}
[Column(name:"PassNPTest14HiScoreCode")]
[StringLength(4)]
public string PassNPTest14HiScoreCode {get; set;}
[Column(name:"PassNPTest14HiScoreDate")]
[StringLength(10)]
public string PassNPTest14HiScoreDate {get; set;}
[Column(name:"PassNPTest14HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest14HiScoreMetNM {get; set;}
[Column(name:"PassNPTest14HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest14HiScorePassedNP {get; set;}
[Column(name:"PassNPTest14HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest14HiScoreReqMin {get; set;}
[Column(name:"PassNPTest14HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest14HiScoreReqPass {get; set;}
[Column(name:"PassNPTest14HiScoreScore")]
[StringLength(4)]
public string PassNPTest14HiScoreScore {get; set;}
[Column(name:"PassNPTest15HiScoreCode")]
[StringLength(4)]
public string PassNPTest15HiScoreCode {get; set;}
[Column(name:"PassNPTest15HiScoreDate")]
[StringLength(10)]
public string PassNPTest15HiScoreDate {get; set;}
[Column(name:"PassNPTest15HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest15HiScoreMetNM {get; set;}
[Column(name:"PassNPTest15HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest15HiScorePassedNP {get; set;}
[Column(name:"PassNPTest15HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest15HiScoreReqMin {get; set;}
[Column(name:"PassNPTest15HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest15HiScoreReqPass {get; set;}
[Column(name:"PassNPTest15HiScoreScore")]
[StringLength(4)]
public string PassNPTest15HiScoreScore {get; set;}
[Column(name:"PassNPTest16HiScoreCode")]
[StringLength(4)]
public string PassNPTest16HiScoreCode {get; set;}
[Column(name:"PassNPTest16HiScoreDate")]
[StringLength(10)]
public string PassNPTest16HiScoreDate {get; set;}
[Column(name:"PassNPTest16HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest16HiScoreMetNM {get; set;}
[Column(name:"PassNPTest16HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest16HiScorePassedNP {get; set;}
[Column(name:"PassNPTest16HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest16HiScoreReqMin {get; set;}
[Column(name:"PassNPTest16HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest16HiScoreReqPass {get; set;}
[Column(name:"PassNPTest16HiScoreScore")]
[StringLength(4)]
public string PassNPTest16HiScoreScore {get; set;}
[Column(name:"PassNPTest17HiScoreCode")]
[StringLength(4)]
public string PassNPTest17HiScoreCode {get; set;}
[Column(name:"PassNPTest17HiScoreDate")]
[StringLength(10)]
public string PassNPTest17HiScoreDate {get; set;}
[Column(name:"PassNPTest17HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest17HiScoreMetNM {get; set;}
[Column(name:"PassNPTest17HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest17HiScorePassedNP {get; set;}
[Column(name:"PassNPTest17HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest17HiScoreReqMin {get; set;}
[Column(name:"PassNPTest17HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest17HiScoreReqPass {get; set;}
[Column(name:"PassNPTest17HiScoreScore")]
[StringLength(4)]
public string PassNPTest17HiScoreScore {get; set;}
[Column(name:"PassNPTest18HiScoreCode")]
[StringLength(4)]
public string PassNPTest18HiScoreCode {get; set;}
[Column(name:"PassNPTest18HiScoreDate")]
[StringLength(10)]
public string PassNPTest18HiScoreDate {get; set;}
[Column(name:"PassNPTest18HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest18HiScoreMetNM {get; set;}
[Column(name:"PassNPTest18HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest18HiScorePassedNP {get; set;}
[Column(name:"PassNPTest18HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest18HiScoreReqMin {get; set;}
[Column(name:"PassNPTest18HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest18HiScoreReqPass {get; set;}
[Column(name:"PassNPTest18HiScoreScore")]
[StringLength(4)]
public string PassNPTest18HiScoreScore {get; set;}
[Column(name:"PassNPTest19HiScoreCode")]
[StringLength(4)]
public string PassNPTest19HiScoreCode {get; set;}
[Column(name:"PassNPTest19HiScoreDate")]
[StringLength(10)]
public string PassNPTest19HiScoreDate {get; set;}
[Column(name:"PassNPTest19HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest19HiScoreMetNM {get; set;}
[Column(name:"PassNPTest19HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest19HiScorePassedNP {get; set;}
[Column(name:"PassNPTest19HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest19HiScoreReqMin {get; set;}
[Column(name:"PassNPTest19HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest19HiScoreReqPass {get; set;}
[Column(name:"PassNPTest19HiScoreScore")]
[StringLength(4)]
public string PassNPTest19HiScoreScore {get; set;}
[Column(name:"PassNPTest1HiScoreCode")]
[StringLength(4)]
public string PassNPTest1HiScoreCode {get; set;}
[Column(name:"PassNPTest1HiScoreDate")]
[StringLength(10)]
public string PassNPTest1HiScoreDate {get; set;}
[Column(name:"PassNPTest1HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest1HiScoreMetNM {get; set;}
[Column(name:"PassNPTest1HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest1HiScorePassedNP {get; set;}
[Column(name:"PassNPTest1HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest1HiScoreReqMin {get; set;}
[Column(name:"PassNPTest1HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest1HiScoreReqPass {get; set;}
[Column(name:"PassNPTest1HiScoreScore")]
[StringLength(4)]
public string PassNPTest1HiScoreScore {get; set;}
[Column(name:"PassNPTest20HiScoreCode")]
[StringLength(4)]
public string PassNPTest20HiScoreCode {get; set;}
[Column(name:"PassNPTest20HiScoreDate")]
[StringLength(10)]
public string PassNPTest20HiScoreDate {get; set;}
[Column(name:"PassNPTest20HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest20HiScoreMetNM {get; set;}
[Column(name:"PassNPTest20HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest20HiScorePassedNP {get; set;}
[Column(name:"PassNPTest20HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest20HiScoreReqMin {get; set;}
[Column(name:"PassNPTest20HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest20HiScoreReqPass {get; set;}
[Column(name:"PassNPTest20HiScoreScore")]
[StringLength(4)]
public string PassNPTest20HiScoreScore {get; set;}
[Column(name:"PassNPTest21HiScoreCode")]
[StringLength(4)]
public string PassNPTest21HiScoreCode {get; set;}
[Column(name:"PassNPTest21HiScoreDate")]
[StringLength(10)]
public string PassNPTest21HiScoreDate {get; set;}
[Column(name:"PassNPTest21HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest21HiScoreMetNM {get; set;}
[Column(name:"PassNPTest21HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest21HiScorePassedNP {get; set;}
[Column(name:"PassNPTest21HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest21HiScoreReqMin {get; set;}
[Column(name:"PassNPTest21HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest21HiScoreReqPass {get; set;}
[Column(name:"PassNPTest21HiScoreScore")]
[StringLength(4)]
public string PassNPTest21HiScoreScore {get; set;}
[Column(name:"PassNPTest22HiScoreCode")]
[StringLength(4)]
public string PassNPTest22HiScoreCode {get; set;}
[Column(name:"PassNPTest22HiScoreDate")]
[StringLength(10)]
public string PassNPTest22HiScoreDate {get; set;}
[Column(name:"PassNPTest22HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest22HiScoreMetNM {get; set;}
[Column(name:"PassNPTest22HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest22HiScorePassedNP {get; set;}
[Column(name:"PassNPTest22HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest22HiScoreReqMin {get; set;}
[Column(name:"PassNPTest22HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest22HiScoreReqPass {get; set;}
[Column(name:"PassNPTest22HiScoreScore")]
[StringLength(4)]
public string PassNPTest22HiScoreScore {get; set;}
[Column(name:"PassNPTest23HiScoreCode")]
[StringLength(4)]
public string PassNPTest23HiScoreCode {get; set;}
[Column(name:"PassNPTest23HiScoreDate")]
[StringLength(10)]
public string PassNPTest23HiScoreDate {get; set;}
[Column(name:"PassNPTest23HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest23HiScoreMetNM {get; set;}
[Column(name:"PassNPTest23HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest23HiScorePassedNP {get; set;}
[Column(name:"PassNPTest23HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest23HiScoreReqMin {get; set;}
[Column(name:"PassNPTest23HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest23HiScoreReqPass {get; set;}
[Column(name:"PassNPTest23HiScoreScore")]
[StringLength(4)]
public string PassNPTest23HiScoreScore {get; set;}
[Column(name:"PassNPTest24HiScoreCode")]
[StringLength(4)]
public string PassNPTest24HiScoreCode {get; set;}
[Column(name:"PassNPTest24HiScoreDate")]
[StringLength(10)]
public string PassNPTest24HiScoreDate {get; set;}
[Column(name:"PassNPTest24HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest24HiScoreMetNM {get; set;}
[Column(name:"PassNPTest24HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest24HiScorePassedNP {get; set;}
[Column(name:"PassNPTest24HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest24HiScoreReqMin {get; set;}
[Column(name:"PassNPTest24HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest24HiScoreReqPass {get; set;}
[Column(name:"PassNPTest24HiScoreScore")]
[StringLength(4)]
public string PassNPTest24HiScoreScore {get; set;}
[Column(name:"PassNPTest25HiScoreCode")]
[StringLength(4)]
public string PassNPTest25HiScoreCode {get; set;}
[Column(name:"PassNPTest25HiScoreDate")]
[StringLength(10)]
public string PassNPTest25HiScoreDate {get; set;}
[Column(name:"PassNPTest25HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest25HiScoreMetNM {get; set;}
[Column(name:"PassNPTest25HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest25HiScorePassedNP {get; set;}
[Column(name:"PassNPTest25HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest25HiScoreReqMin {get; set;}
[Column(name:"PassNPTest25HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest25HiScoreReqPass {get; set;}
[Column(name:"PassNPTest25HiScoreScore")]
[StringLength(4)]
public string PassNPTest25HiScoreScore {get; set;}
[Column(name:"PassNPTest26HiScoreCode")]
[StringLength(4)]
public string PassNPTest26HiScoreCode {get; set;}
[Column(name:"PassNPTest26HiScoreDate")]
[StringLength(10)]
public string PassNPTest26HiScoreDate {get; set;}
[Column(name:"PassNPTest26HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest26HiScoreMetNM {get; set;}
[Column(name:"PassNPTest26HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest26HiScorePassedNP {get; set;}
[Column(name:"PassNPTest26HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest26HiScoreReqMin {get; set;}
[Column(name:"PassNPTest26HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest26HiScoreReqPass {get; set;}
[Column(name:"PassNPTest26HiScoreScore")]
[StringLength(4)]
public string PassNPTest26HiScoreScore {get; set;}
[Column(name:"PassNPTest27HiScoreCode")]
[StringLength(4)]
public string PassNPTest27HiScoreCode {get; set;}
[Column(name:"PassNPTest27HiScoreDate")]
[StringLength(10)]
public string PassNPTest27HiScoreDate {get; set;}
[Column(name:"PassNPTest27HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest27HiScoreMetNM {get; set;}
[Column(name:"PassNPTest27HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest27HiScorePassedNP {get; set;}
[Column(name:"PassNPTest27HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest27HiScoreReqMin {get; set;}
[Column(name:"PassNPTest27HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest27HiScoreReqPass {get; set;}
[Column(name:"PassNPTest27HiScoreScore")]
[StringLength(4)]
public string PassNPTest27HiScoreScore {get; set;}
[Column(name:"PassNPTest28HiScoreCode")]
[StringLength(4)]
public string PassNPTest28HiScoreCode {get; set;}
[Column(name:"PassNPTest28HiScoreDate")]
[StringLength(10)]
public string PassNPTest28HiScoreDate {get; set;}
[Column(name:"PassNPTest28HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest28HiScoreMetNM {get; set;}
[Column(name:"PassNPTest28HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest28HiScorePassedNP {get; set;}
[Column(name:"PassNPTest28HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest28HiScoreReqMin {get; set;}
[Column(name:"PassNPTest28HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest28HiScoreReqPass {get; set;}
[Column(name:"PassNPTest28HiScoreScore")]
[StringLength(4)]
public string PassNPTest28HiScoreScore {get; set;}
[Column(name:"PassNPTest29HiScoreCode")]
[StringLength(4)]
public string PassNPTest29HiScoreCode {get; set;}
[Column(name:"PassNPTest29HiScoreDate")]
[StringLength(10)]
public string PassNPTest29HiScoreDate {get; set;}
[Column(name:"PassNPTest29HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest29HiScoreMetNM {get; set;}
[Column(name:"PassNPTest29HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest29HiScorePassedNP {get; set;}
[Column(name:"PassNPTest29HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest29HiScoreReqMin {get; set;}
[Column(name:"PassNPTest29HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest29HiScoreReqPass {get; set;}
[Column(name:"PassNPTest29HiScoreScore")]
[StringLength(4)]
public string PassNPTest29HiScoreScore {get; set;}
[Column(name:"PassNPTest2HiScoreCode")]
[StringLength(4)]
public string PassNPTest2HiScoreCode {get; set;}
[Column(name:"PassNPTest2HiScoreDate")]
[StringLength(10)]
public string PassNPTest2HiScoreDate {get; set;}
[Column(name:"PassNPTest2HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest2HiScoreMetNM {get; set;}
[Column(name:"PassNPTest2HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest2HiScorePassedNP {get; set;}
[Column(name:"PassNPTest2HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest2HiScoreReqMin {get; set;}
[Column(name:"PassNPTest2HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest2HiScoreReqPass {get; set;}
[Column(name:"PassNPTest2HiScoreScore")]
[StringLength(4)]
public string PassNPTest2HiScoreScore {get; set;}
[Column(name:"PassNPTest30HiScoreCode")]
[StringLength(4)]
public string PassNPTest30HiScoreCode {get; set;}
[Column(name:"PassNPTest30HiScoreDate")]
[StringLength(10)]
public string PassNPTest30HiScoreDate {get; set;}
[Column(name:"PassNPTest30HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest30HiScoreMetNM {get; set;}
[Column(name:"PassNPTest30HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest30HiScorePassedNP {get; set;}
[Column(name:"PassNPTest30HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest30HiScoreReqMin {get; set;}
[Column(name:"PassNPTest30HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest30HiScoreReqPass {get; set;}
[Column(name:"PassNPTest30HiScoreScore")]
[StringLength(4)]
public string PassNPTest30HiScoreScore {get; set;}
[Column(name:"PassNPTest31HiScoreCode")]
[StringLength(4)]
public string PassNPTest31HiScoreCode {get; set;}
[Column(name:"PassNPTest31HiScoreDate")]
[StringLength(10)]
public string PassNPTest31HiScoreDate {get; set;}
[Column(name:"PassNPTest31HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest31HiScoreMetNM {get; set;}
[Column(name:"PassNPTest31HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest31HiScorePassedNP {get; set;}
[Column(name:"PassNPTest31HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest31HiScoreReqMin {get; set;}
[Column(name:"PassNPTest31HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest31HiScoreReqPass {get; set;}
[Column(name:"PassNPTest31HiScoreScore")]
[StringLength(4)]
public string PassNPTest31HiScoreScore {get; set;}
[Column(name:"PassNPTest32HiScoreCode")]
[StringLength(4)]
public string PassNPTest32HiScoreCode {get; set;}
[Column(name:"PassNPTest32HiScoreDate")]
[StringLength(10)]
public string PassNPTest32HiScoreDate {get; set;}
[Column(name:"PassNPTest32HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest32HiScoreMetNM {get; set;}
[Column(name:"PassNPTest32HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest32HiScorePassedNP {get; set;}
[Column(name:"PassNPTest32HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest32HiScoreReqMin {get; set;}
[Column(name:"PassNPTest32HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest32HiScoreReqPass {get; set;}
[Column(name:"PassNPTest32HiScoreScore")]
[StringLength(4)]
public string PassNPTest32HiScoreScore {get; set;}
[Column(name:"PassNPTest33HiScoreCode")]
[StringLength(4)]
public string PassNPTest33HiScoreCode {get; set;}
[Column(name:"PassNPTest33HiScoreDate")]
[StringLength(10)]
public string PassNPTest33HiScoreDate {get; set;}
[Column(name:"PassNPTest33HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest33HiScoreMetNM {get; set;}
[Column(name:"PassNPTest33HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest33HiScorePassedNP {get; set;}
[Column(name:"PassNPTest33HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest33HiScoreReqMin {get; set;}
[Column(name:"PassNPTest33HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest33HiScoreReqPass {get; set;}
[Column(name:"PassNPTest33HiScoreScore")]
[StringLength(4)]
public string PassNPTest33HiScoreScore {get; set;}
[Column(name:"PassNPTest34HiScoreCode")]
[StringLength(4)]
public string PassNPTest34HiScoreCode {get; set;}
[Column(name:"PassNPTest34HiScoreDate")]
[StringLength(10)]
public string PassNPTest34HiScoreDate {get; set;}
[Column(name:"PassNPTest34HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest34HiScoreMetNM {get; set;}
[Column(name:"PassNPTest34HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest34HiScorePassedNP {get; set;}
[Column(name:"PassNPTest34HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest34HiScoreReqMin {get; set;}
[Column(name:"PassNPTest34HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest34HiScoreReqPass {get; set;}
[Column(name:"PassNPTest34HiScoreScore")]
[StringLength(4)]
public string PassNPTest34HiScoreScore {get; set;}
[Column(name:"PassNPTest35HiScoreCode")]
[StringLength(4)]
public string PassNPTest35HiScoreCode {get; set;}
[Column(name:"PassNPTest35HiScoreDate")]
[StringLength(10)]
public string PassNPTest35HiScoreDate {get; set;}
[Column(name:"PassNPTest35HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest35HiScoreMetNM {get; set;}
[Column(name:"PassNPTest35HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest35HiScorePassedNP {get; set;}
[Column(name:"PassNPTest35HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest35HiScoreReqMin {get; set;}
[Column(name:"PassNPTest35HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest35HiScoreReqPass {get; set;}
[Column(name:"PassNPTest35HiScoreScore")]
[StringLength(4)]
public string PassNPTest35HiScoreScore {get; set;}
[Column(name:"PassNPTest36HiScoreCode")]
[StringLength(4)]
public string PassNPTest36HiScoreCode {get; set;}
[Column(name:"PassNPTest36HiScoreDate")]
[StringLength(10)]
public string PassNPTest36HiScoreDate {get; set;}
[Column(name:"PassNPTest36HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest36HiScoreMetNM {get; set;}
[Column(name:"PassNPTest36HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest36HiScorePassedNP {get; set;}
[Column(name:"PassNPTest36HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest36HiScoreReqMin {get; set;}
[Column(name:"PassNPTest36HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest36HiScoreReqPass {get; set;}
[Column(name:"PassNPTest36HiScoreScore")]
[StringLength(4)]
public string PassNPTest36HiScoreScore {get; set;}
[Column(name:"PassNPTest3HiScoreCode")]
[StringLength(4)]
public string PassNPTest3HiScoreCode {get; set;}
[Column(name:"PassNPTest3HiScoreDate")]
[StringLength(10)]
public string PassNPTest3HiScoreDate {get; set;}
[Column(name:"PassNPTest3HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest3HiScoreMetNM {get; set;}
[Column(name:"PassNPTest3HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest3HiScorePassedNP {get; set;}
[Column(name:"PassNPTest3HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest3HiScoreReqMin {get; set;}
[Column(name:"PassNPTest3HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest3HiScoreReqPass {get; set;}
[Column(name:"PassNPTest3HiScoreScore")]
[StringLength(4)]
public string PassNPTest3HiScoreScore {get; set;}
[Column(name:"PassNPTest4HiScoreCode")]
[StringLength(4)]
public string PassNPTest4HiScoreCode {get; set;}
[Column(name:"PassNPTest4HiScoreDate")]
[StringLength(10)]
public string PassNPTest4HiScoreDate {get; set;}
[Column(name:"PassNPTest4HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest4HiScoreMetNM {get; set;}
[Column(name:"PassNPTest4HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest4HiScorePassedNP {get; set;}
[Column(name:"PassNPTest4HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest4HiScoreReqMin {get; set;}
[Column(name:"PassNPTest4HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest4HiScoreReqPass {get; set;}
[Column(name:"PassNPTest4HiScoreScore")]
[StringLength(4)]
public string PassNPTest4HiScoreScore {get; set;}
[Column(name:"PassNPTest5HiScoreCode")]
[StringLength(4)]
public string PassNPTest5HiScoreCode {get; set;}
[Column(name:"PassNPTest5HiScoreDate")]
[StringLength(10)]
public string PassNPTest5HiScoreDate {get; set;}
[Column(name:"PassNPTest5HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest5HiScoreMetNM {get; set;}
[Column(name:"PassNPTest5HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest5HiScorePassedNP {get; set;}
[Column(name:"PassNPTest5HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest5HiScoreReqMin {get; set;}
[Column(name:"PassNPTest5HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest5HiScoreReqPass {get; set;}
[Column(name:"PassNPTest5HiScoreScore")]
[StringLength(4)]
public string PassNPTest5HiScoreScore {get; set;}
[Column(name:"PassNPTest6HiScoreCode")]
[StringLength(4)]
public string PassNPTest6HiScoreCode {get; set;}
[Column(name:"PassNPTest6HiScoreDate")]
[StringLength(10)]
public string PassNPTest6HiScoreDate {get; set;}
[Column(name:"PassNPTest6HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest6HiScoreMetNM {get; set;}
[Column(name:"PassNPTest6HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest6HiScorePassedNP {get; set;}
[Column(name:"PassNPTest6HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest6HiScoreReqMin {get; set;}
[Column(name:"PassNPTest6HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest6HiScoreReqPass {get; set;}
[Column(name:"PassNPTest6HiScoreScore")]
[StringLength(4)]
public string PassNPTest6HiScoreScore {get; set;}
[Column(name:"PassNPTest7HiScoreCode")]
[StringLength(4)]
public string PassNPTest7HiScoreCode {get; set;}
[Column(name:"PassNPTest7HiScoreDate")]
[StringLength(10)]
public string PassNPTest7HiScoreDate {get; set;}
[Column(name:"PassNPTest7HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest7HiScoreMetNM {get; set;}
[Column(name:"PassNPTest7HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest7HiScorePassedNP {get; set;}
[Column(name:"PassNPTest7HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest7HiScoreReqMin {get; set;}
[Column(name:"PassNPTest7HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest7HiScoreReqPass {get; set;}
[Column(name:"PassNPTest7HiScoreScore")]
[StringLength(4)]
public string PassNPTest7HiScoreScore {get; set;}
[Column(name:"PassNPTest8HiScoreCode")]
[StringLength(4)]
public string PassNPTest8HiScoreCode {get; set;}
[Column(name:"PassNPTest8HiScoreDate")]
[StringLength(10)]
public string PassNPTest8HiScoreDate {get; set;}
[Column(name:"PassNPTest8HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest8HiScoreMetNM {get; set;}
[Column(name:"PassNPTest8HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest8HiScorePassedNP {get; set;}
[Column(name:"PassNPTest8HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest8HiScoreReqMin {get; set;}
[Column(name:"PassNPTest8HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest8HiScoreReqPass {get; set;}
[Column(name:"PassNPTest8HiScoreScore")]
[StringLength(4)]
public string PassNPTest8HiScoreScore {get; set;}
[Column(name:"PassNPTest9HiScoreCode")]
[StringLength(4)]
public string PassNPTest9HiScoreCode {get; set;}
[Column(name:"PassNPTest9HiScoreDate")]
[StringLength(10)]
public string PassNPTest9HiScoreDate {get; set;}
[Column(name:"PassNPTest9HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest9HiScoreMetNM {get; set;}
[Column(name:"PassNPTest9HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest9HiScorePassedNP {get; set;}
[Column(name:"PassNPTest9HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest9HiScoreReqMin {get; set;}
[Column(name:"PassNPTest9HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest9HiScoreReqPass {get; set;}
[Column(name:"PassNPTest9HiScoreScore")]
[StringLength(4)]
public string PassNPTest9HiScoreScore {get; set;}
[Column(name:"ProgramIdentifier")]
[StringLength(6)]
public string ProgramIdentifier {get; set;}
[Column(name:"RecipientCode")]
[StringLength(4)]
public string RecipientCode {get; set;}
[Column(name:"Sex")]
[StringLength(1)]
public string Sex {get; set;}
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Column(name:"State")]
[StringLength(2)]
public string State {get; set;}
[Column(name:"StateCode")]
[StringLength(2)]
public string StateCode {get; set;}
[Column(name:"UndergradGPA")]
[StringLength(3)]
public string UndergradGPA {get; set;}
[Column(name:"UndergradMajor")]
[StringLength(3)]
public string UndergradMajor {get; set;}
[Required]
[Column(name:"UniqueRecNum")]
[StringLength(1)]
public string UniqueRecNum {get; set;}
[Column(name:"Zip")]
[StringLength(9)]
public string Zip {get; set;}
[ForeignKey("ETSFileRecordID")]
public virtual ICollection<OCETSPraxisTest> OCETSPraxisTests{get; set;}
}
[Table("ScoreLinkDataAudit")]
public partial class ScoreLinkDataAudit
:IAudit{ 
public ScoreLinkDataAudit()
{
}
[Column(name:"Address")]
[StringLength(30)]
public string Address {get; set;}
[Column(name:"AttendInst")]
[StringLength(4)]
public string AttendInst {get; set;}
[Required]
[Column(name:"BirthDate")]
[StringLength(10)]
public string BirthDate {get; set;}
[Column(name:"CandidateIDNumber")]
[StringLength(8)]
public string CandidateIDNumber {get; set;}
[Column(name:"City")]
[StringLength(14)]
public string City {get; set;}
[Column(name:"CountryCode")]
[StringLength(3)]
public string CountryCode {get; set;}
[Column(name:"CreationDate")]
[StringLength(8)]
public string CreationDate {get; set;}
[Column(name:"CurrTest1Code")]
[StringLength(4)]
public string CurrTest1Code {get; set;}
[Column(name:"CurrTest1Date")]
[StringLength(8)]
public string CurrTest1Date {get; set;}
[Column(name:"CurrTest1Filler")]
[StringLength(1)]
public string CurrTest1Filler {get; set;}
[Column(name:"CurrTest1NonStandAdmin")]
[StringLength(1)]
public string CurrTest1NonStandAdmin {get; set;}
[Column(name:"CurrTest1ROE")]
[StringLength(1)]
public string CurrTest1ROE {get; set;}
[Column(name:"CurrTest1Score")]
[StringLength(3)]
public string CurrTest1Score {get; set;}
[Column(name:"CurrTest2Code")]
[StringLength(4)]
public string CurrTest2Code {get; set;}
[Column(name:"CurrTest2Date")]
[StringLength(8)]
public string CurrTest2Date {get; set;}
[Column(name:"CurrTest2Filler")]
[StringLength(1)]
public string CurrTest2Filler {get; set;}
[Column(name:"CurrTest2NonStandAdmin")]
[StringLength(1)]
public string CurrTest2NonStandAdmin {get; set;}
[Column(name:"CurrTest2ROE")]
[StringLength(1)]
public string CurrTest2ROE {get; set;}
[Column(name:"CurrTest2Score")]
[StringLength(3)]
public string CurrTest2Score {get; set;}
[Column(name:"CurrTest3Code")]
[StringLength(4)]
public string CurrTest3Code {get; set;}
[Column(name:"CurrTest3Date")]
[StringLength(8)]
public string CurrTest3Date {get; set;}
[Column(name:"CurrTest3Filler")]
[StringLength(1)]
public string CurrTest3Filler {get; set;}
[Column(name:"CurrTest3NonStandAdmin")]
[StringLength(1)]
public string CurrTest3NonStandAdmin {get; set;}
[Column(name:"CurrTest3ROE")]
[StringLength(1)]
public string CurrTest3ROE {get; set;}
[Column(name:"CurrTest3Score")]
[StringLength(3)]
public string CurrTest3Score {get; set;}
[Column(name:"CurrTest4Code")]
[StringLength(4)]
public string CurrTest4Code {get; set;}
[Column(name:"CurrTest4Date")]
[StringLength(8)]
public string CurrTest4Date {get; set;}
[Column(name:"CurrTest4Filler")]
[StringLength(1)]
public string CurrTest4Filler {get; set;}
[Column(name:"CurrTest4NonStandAdmin")]
[StringLength(1)]
public string CurrTest4NonStandAdmin {get; set;}
[Column(name:"CurrTest4ROE")]
[StringLength(1)]
public string CurrTest4ROE {get; set;}
[Column(name:"CurrTest4Score")]
[StringLength(3)]
public string CurrTest4Score {get; set;}
[Column(name:"CurrTest5Code")]
[StringLength(4)]
public string CurrTest5Code {get; set;}
[Column(name:"CurrTest5Date")]
[StringLength(8)]
public string CurrTest5Date {get; set;}
[Column(name:"CurrTest5Filler")]
[StringLength(1)]
public string CurrTest5Filler {get; set;}
[Column(name:"CurrTest5NonStandAdmin")]
[StringLength(1)]
public string CurrTest5NonStandAdmin {get; set;}
[Column(name:"CurrTest5ROE")]
[StringLength(1)]
public string CurrTest5ROE {get; set;}
[Column(name:"CurrTest5Score")]
[StringLength(3)]
public string CurrTest5Score {get; set;}
[Column(name:"CurrTest6Code")]
[StringLength(4)]
public string CurrTest6Code {get; set;}
[Column(name:"CurrTest6Date")]
[StringLength(8)]
public string CurrTest6Date {get; set;}
[Column(name:"CurrTest6Filler")]
[StringLength(1)]
public string CurrTest6Filler {get; set;}
[Column(name:"CurrTest6NonStandAdmin")]
[StringLength(1)]
public string CurrTest6NonStandAdmin {get; set;}
[Column(name:"CurrTest6ROE")]
[StringLength(1)]
public string CurrTest6ROE {get; set;}
[Column(name:"CurrTest6Score")]
[StringLength(3)]
public string CurrTest6Score {get; set;}
[Column(name:"DateRecvd",TypeName = "datetime2")]
public DateTime? DateRecvd {get; set;}
[Column(name:"EducationLevel")]
[StringLength(3)]
public string EducationLevel {get; set;}
[Column(name:"EthnicityCode")]
[StringLength(3)]
public string EthnicityCode {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(10)]
public string FirstName {get; set;}
[Column(name:"GradMajor")]
[StringLength(3)]
public string GradMajor {get; set;}
[Column(name:"HiScoreTest10Code")]
[StringLength(4)]
public string HiScoreTest10Code {get; set;}
[Column(name:"HiScoreTest10Date")]
[StringLength(8)]
public string HiScoreTest10Date {get; set;}
[Column(name:"HiScoreTest10NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest10NonStandAdmin {get; set;}
[Column(name:"HiScoreTest10ROE")]
[StringLength(1)]
public string HiScoreTest10ROE {get; set;}
[Column(name:"HiScoreTest10RSI")]
[StringLength(1)]
public string HiScoreTest10RSI {get; set;}
[Column(name:"HiScoreTest10Score")]
[StringLength(3)]
public string HiScoreTest10Score {get; set;}
[Column(name:"HiScoreTest1Code")]
[StringLength(4)]
public string HiScoreTest1Code {get; set;}
[Column(name:"HiScoreTest1Date")]
[StringLength(8)]
public string HiScoreTest1Date {get; set;}
[Column(name:"HiScoreTest1NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest1NonStandAdmin {get; set;}
[Column(name:"HiScoreTest1ROE")]
[StringLength(1)]
public string HiScoreTest1ROE {get; set;}
[Column(name:"HiScoreTest1RSI")]
[StringLength(1)]
public string HiScoreTest1RSI {get; set;}
[Column(name:"HiScoreTest1Score")]
[StringLength(3)]
public string HiScoreTest1Score {get; set;}
[Column(name:"HiScoreTest2Code")]
[StringLength(4)]
public string HiScoreTest2Code {get; set;}
[Column(name:"HiScoreTest2Date")]
[StringLength(8)]
public string HiScoreTest2Date {get; set;}
[Column(name:"HiScoreTest2NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest2NonStandAdmin {get; set;}
[Column(name:"HiScoreTest2ROE")]
[StringLength(1)]
public string HiScoreTest2ROE {get; set;}
[Column(name:"HiScoreTest2RSI")]
[StringLength(1)]
public string HiScoreTest2RSI {get; set;}
[Column(name:"HiScoreTest2Score")]
[StringLength(3)]
public string HiScoreTest2Score {get; set;}
[Column(name:"HiScoreTest3Code")]
[StringLength(4)]
public string HiScoreTest3Code {get; set;}
[Column(name:"HiScoreTest3Date")]
[StringLength(8)]
public string HiScoreTest3Date {get; set;}
[Column(name:"HiScoreTest3NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest3NonStandAdmin {get; set;}
[Column(name:"HiScoreTest3ROE")]
[StringLength(1)]
public string HiScoreTest3ROE {get; set;}
[Column(name:"HiScoreTest3RSI")]
[StringLength(1)]
public string HiScoreTest3RSI {get; set;}
[Column(name:"HiScoreTest3Score")]
[StringLength(3)]
public string HiScoreTest3Score {get; set;}
[Column(name:"HiScoreTest4Code")]
[StringLength(4)]
public string HiScoreTest4Code {get; set;}
[Column(name:"HiScoreTest4Date")]
[StringLength(8)]
public string HiScoreTest4Date {get; set;}
[Column(name:"HiScoreTest4NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest4NonStandAdmin {get; set;}
[Column(name:"HiScoreTest4ROE")]
[StringLength(1)]
public string HiScoreTest4ROE {get; set;}
[Column(name:"HiScoreTest4RSI")]
[StringLength(1)]
public string HiScoreTest4RSI {get; set;}
[Column(name:"HiScoreTest4Score")]
[StringLength(3)]
public string HiScoreTest4Score {get; set;}
[Column(name:"HiScoreTest5Code")]
[StringLength(4)]
public string HiScoreTest5Code {get; set;}
[Column(name:"HiScoreTest5Date")]
[StringLength(8)]
public string HiScoreTest5Date {get; set;}
[Column(name:"HiScoreTest5NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest5NonStandAdmin {get; set;}
[Column(name:"HiScoreTest5ROE")]
[StringLength(1)]
public string HiScoreTest5ROE {get; set;}
[Column(name:"HiScoreTest5RSI")]
[StringLength(1)]
public string HiScoreTest5RSI {get; set;}
[Column(name:"HiScoreTest5Score")]
[StringLength(3)]
public string HiScoreTest5Score {get; set;}
[Column(name:"HiScoreTest6Code")]
[StringLength(4)]
public string HiScoreTest6Code {get; set;}
[Column(name:"HiScoreTest6Date")]
[StringLength(8)]
public string HiScoreTest6Date {get; set;}
[Column(name:"HiScoreTest6NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest6NonStandAdmin {get; set;}
[Column(name:"HiScoreTest6ROE")]
[StringLength(1)]
public string HiScoreTest6ROE {get; set;}
[Column(name:"HiScoreTest6RSI")]
[StringLength(1)]
public string HiScoreTest6RSI {get; set;}
[Column(name:"HiScoreTest6Score")]
[StringLength(3)]
public string HiScoreTest6Score {get; set;}
[Column(name:"HiScoreTest7Code")]
[StringLength(4)]
public string HiScoreTest7Code {get; set;}
[Column(name:"HiScoreTest7Date")]
[StringLength(8)]
public string HiScoreTest7Date {get; set;}
[Column(name:"HiScoreTest7NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest7NonStandAdmin {get; set;}
[Column(name:"HiScoreTest7ROE")]
[StringLength(1)]
public string HiScoreTest7ROE {get; set;}
[Column(name:"HiScoreTest7RSI")]
[StringLength(1)]
public string HiScoreTest7RSI {get; set;}
[Column(name:"HiScoreTest7Score")]
[StringLength(3)]
public string HiScoreTest7Score {get; set;}
[Column(name:"HiScoreTest8Code")]
[StringLength(4)]
public string HiScoreTest8Code {get; set;}
[Column(name:"HiScoreTest8Date")]
[StringLength(8)]
public string HiScoreTest8Date {get; set;}
[Column(name:"HiScoreTest8NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest8NonStandAdmin {get; set;}
[Column(name:"HiScoreTest8ROE")]
[StringLength(1)]
public string HiScoreTest8ROE {get; set;}
[Column(name:"HiScoreTest8RSI")]
[StringLength(1)]
public string HiScoreTest8RSI {get; set;}
[Column(name:"HiScoreTest8Score")]
[StringLength(3)]
public string HiScoreTest8Score {get; set;}
[Column(name:"HiScoreTest9Code")]
[StringLength(4)]
public string HiScoreTest9Code {get; set;}
[Column(name:"HiScoreTest9Date")]
[StringLength(8)]
public string HiScoreTest9Date {get; set;}
[Column(name:"HiScoreTest9NonStandAdmin")]
[StringLength(1)]
public string HiScoreTest9NonStandAdmin {get; set;}
[Column(name:"HiScoreTest9ROE")]
[StringLength(1)]
public string HiScoreTest9ROE {get; set;}
[Column(name:"HiScoreTest9RSI")]
[StringLength(1)]
public string HiScoreTest9RSI {get; set;}
[Column(name:"HiScoreTest9Score")]
[StringLength(3)]
public string HiScoreTest9Score {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(15)]
public string LastName {get; set;}
[Column(name:"LowValueFiller")]
[StringLength(6)]
public string LowValueFiller {get; set;}
[Column(name:"MiddleInitial")]
[StringLength(1)]
public string MiddleInitial {get; set;}
[Column(name:"PassNPTest10HiScoreCode")]
[StringLength(4)]
public string PassNPTest10HiScoreCode {get; set;}
[Column(name:"PassNPTest10HiScoreDate")]
[StringLength(10)]
public string PassNPTest10HiScoreDate {get; set;}
[Column(name:"PassNPTest10HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest10HiScoreMetNM {get; set;}
[Column(name:"PassNPTest10HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest10HiScorePassedNP {get; set;}
[Column(name:"PassNPTest10HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest10HiScoreReqMin {get; set;}
[Column(name:"PassNPTest10HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest10HiScoreReqPass {get; set;}
[Column(name:"PassNPTest10HiScoreScore")]
[StringLength(4)]
public string PassNPTest10HiScoreScore {get; set;}
[Column(name:"PassNPTest11HiScoreCode")]
[StringLength(4)]
public string PassNPTest11HiScoreCode {get; set;}
[Column(name:"PassNPTest11HiScoreDate")]
[StringLength(10)]
public string PassNPTest11HiScoreDate {get; set;}
[Column(name:"PassNPTest11HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest11HiScoreMetNM {get; set;}
[Column(name:"PassNPTest11HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest11HiScorePassedNP {get; set;}
[Column(name:"PassNPTest11HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest11HiScoreReqMin {get; set;}
[Column(name:"PassNPTest11HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest11HiScoreReqPass {get; set;}
[Column(name:"PassNPTest11HiScoreScore")]
[StringLength(4)]
public string PassNPTest11HiScoreScore {get; set;}
[Column(name:"PassNPTest12HiScoreCode")]
[StringLength(4)]
public string PassNPTest12HiScoreCode {get; set;}
[Column(name:"PassNPTest12HiScoreDate")]
[StringLength(10)]
public string PassNPTest12HiScoreDate {get; set;}
[Column(name:"PassNPTest12HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest12HiScoreMetNM {get; set;}
[Column(name:"PassNPTest12HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest12HiScorePassedNP {get; set;}
[Column(name:"PassNPTest12HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest12HiScoreReqMin {get; set;}
[Column(name:"PassNPTest12HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest12HiScoreReqPass {get; set;}
[Column(name:"PassNPTest12HiScoreScore")]
[StringLength(4)]
public string PassNPTest12HiScoreScore {get; set;}
[Column(name:"PassNPTest13HiScoreCode")]
[StringLength(4)]
public string PassNPTest13HiScoreCode {get; set;}
[Column(name:"PassNPTest13HiScoreDate")]
[StringLength(10)]
public string PassNPTest13HiScoreDate {get; set;}
[Column(name:"PassNPTest13HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest13HiScoreMetNM {get; set;}
[Column(name:"PassNPTest13HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest13HiScorePassedNP {get; set;}
[Column(name:"PassNPTest13HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest13HiScoreReqMin {get; set;}
[Column(name:"PassNPTest13HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest13HiScoreReqPass {get; set;}
[Column(name:"PassNPTest13HiScoreScore")]
[StringLength(4)]
public string PassNPTest13HiScoreScore {get; set;}
[Column(name:"PassNPTest14HiScoreCode")]
[StringLength(4)]
public string PassNPTest14HiScoreCode {get; set;}
[Column(name:"PassNPTest14HiScoreDate")]
[StringLength(10)]
public string PassNPTest14HiScoreDate {get; set;}
[Column(name:"PassNPTest14HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest14HiScoreMetNM {get; set;}
[Column(name:"PassNPTest14HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest14HiScorePassedNP {get; set;}
[Column(name:"PassNPTest14HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest14HiScoreReqMin {get; set;}
[Column(name:"PassNPTest14HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest14HiScoreReqPass {get; set;}
[Column(name:"PassNPTest14HiScoreScore")]
[StringLength(4)]
public string PassNPTest14HiScoreScore {get; set;}
[Column(name:"PassNPTest15HiScoreCode")]
[StringLength(4)]
public string PassNPTest15HiScoreCode {get; set;}
[Column(name:"PassNPTest15HiScoreDate")]
[StringLength(10)]
public string PassNPTest15HiScoreDate {get; set;}
[Column(name:"PassNPTest15HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest15HiScoreMetNM {get; set;}
[Column(name:"PassNPTest15HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest15HiScorePassedNP {get; set;}
[Column(name:"PassNPTest15HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest15HiScoreReqMin {get; set;}
[Column(name:"PassNPTest15HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest15HiScoreReqPass {get; set;}
[Column(name:"PassNPTest15HiScoreScore")]
[StringLength(4)]
public string PassNPTest15HiScoreScore {get; set;}
[Column(name:"PassNPTest16HiScoreCode")]
[StringLength(4)]
public string PassNPTest16HiScoreCode {get; set;}
[Column(name:"PassNPTest16HiScoreDate")]
[StringLength(10)]
public string PassNPTest16HiScoreDate {get; set;}
[Column(name:"PassNPTest16HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest16HiScoreMetNM {get; set;}
[Column(name:"PassNPTest16HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest16HiScorePassedNP {get; set;}
[Column(name:"PassNPTest16HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest16HiScoreReqMin {get; set;}
[Column(name:"PassNPTest16HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest16HiScoreReqPass {get; set;}
[Column(name:"PassNPTest16HiScoreScore")]
[StringLength(4)]
public string PassNPTest16HiScoreScore {get; set;}
[Column(name:"PassNPTest17HiScoreCode")]
[StringLength(4)]
public string PassNPTest17HiScoreCode {get; set;}
[Column(name:"PassNPTest17HiScoreDate")]
[StringLength(10)]
public string PassNPTest17HiScoreDate {get; set;}
[Column(name:"PassNPTest17HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest17HiScoreMetNM {get; set;}
[Column(name:"PassNPTest17HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest17HiScorePassedNP {get; set;}
[Column(name:"PassNPTest17HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest17HiScoreReqMin {get; set;}
[Column(name:"PassNPTest17HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest17HiScoreReqPass {get; set;}
[Column(name:"PassNPTest17HiScoreScore")]
[StringLength(4)]
public string PassNPTest17HiScoreScore {get; set;}
[Column(name:"PassNPTest18HiScoreCode")]
[StringLength(4)]
public string PassNPTest18HiScoreCode {get; set;}
[Column(name:"PassNPTest18HiScoreDate")]
[StringLength(10)]
public string PassNPTest18HiScoreDate {get; set;}
[Column(name:"PassNPTest18HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest18HiScoreMetNM {get; set;}
[Column(name:"PassNPTest18HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest18HiScorePassedNP {get; set;}
[Column(name:"PassNPTest18HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest18HiScoreReqMin {get; set;}
[Column(name:"PassNPTest18HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest18HiScoreReqPass {get; set;}
[Column(name:"PassNPTest18HiScoreScore")]
[StringLength(4)]
public string PassNPTest18HiScoreScore {get; set;}
[Column(name:"PassNPTest19HiScoreCode")]
[StringLength(4)]
public string PassNPTest19HiScoreCode {get; set;}
[Column(name:"PassNPTest19HiScoreDate")]
[StringLength(10)]
public string PassNPTest19HiScoreDate {get; set;}
[Column(name:"PassNPTest19HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest19HiScoreMetNM {get; set;}
[Column(name:"PassNPTest19HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest19HiScorePassedNP {get; set;}
[Column(name:"PassNPTest19HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest19HiScoreReqMin {get; set;}
[Column(name:"PassNPTest19HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest19HiScoreReqPass {get; set;}
[Column(name:"PassNPTest19HiScoreScore")]
[StringLength(4)]
public string PassNPTest19HiScoreScore {get; set;}
[Column(name:"PassNPTest1HiScoreCode")]
[StringLength(4)]
public string PassNPTest1HiScoreCode {get; set;}
[Column(name:"PassNPTest1HiScoreDate")]
[StringLength(10)]
public string PassNPTest1HiScoreDate {get; set;}
[Column(name:"PassNPTest1HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest1HiScoreMetNM {get; set;}
[Column(name:"PassNPTest1HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest1HiScorePassedNP {get; set;}
[Column(name:"PassNPTest1HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest1HiScoreReqMin {get; set;}
[Column(name:"PassNPTest1HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest1HiScoreReqPass {get; set;}
[Column(name:"PassNPTest1HiScoreScore")]
[StringLength(4)]
public string PassNPTest1HiScoreScore {get; set;}
[Column(name:"PassNPTest20HiScoreCode")]
[StringLength(4)]
public string PassNPTest20HiScoreCode {get; set;}
[Column(name:"PassNPTest20HiScoreDate")]
[StringLength(10)]
public string PassNPTest20HiScoreDate {get; set;}
[Column(name:"PassNPTest20HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest20HiScoreMetNM {get; set;}
[Column(name:"PassNPTest20HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest20HiScorePassedNP {get; set;}
[Column(name:"PassNPTest20HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest20HiScoreReqMin {get; set;}
[Column(name:"PassNPTest20HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest20HiScoreReqPass {get; set;}
[Column(name:"PassNPTest20HiScoreScore")]
[StringLength(4)]
public string PassNPTest20HiScoreScore {get; set;}
[Column(name:"PassNPTest21HiScoreCode")]
[StringLength(4)]
public string PassNPTest21HiScoreCode {get; set;}
[Column(name:"PassNPTest21HiScoreDate")]
[StringLength(10)]
public string PassNPTest21HiScoreDate {get; set;}
[Column(name:"PassNPTest21HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest21HiScoreMetNM {get; set;}
[Column(name:"PassNPTest21HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest21HiScorePassedNP {get; set;}
[Column(name:"PassNPTest21HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest21HiScoreReqMin {get; set;}
[Column(name:"PassNPTest21HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest21HiScoreReqPass {get; set;}
[Column(name:"PassNPTest21HiScoreScore")]
[StringLength(4)]
public string PassNPTest21HiScoreScore {get; set;}
[Column(name:"PassNPTest22HiScoreCode")]
[StringLength(4)]
public string PassNPTest22HiScoreCode {get; set;}
[Column(name:"PassNPTest22HiScoreDate")]
[StringLength(10)]
public string PassNPTest22HiScoreDate {get; set;}
[Column(name:"PassNPTest22HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest22HiScoreMetNM {get; set;}
[Column(name:"PassNPTest22HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest22HiScorePassedNP {get; set;}
[Column(name:"PassNPTest22HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest22HiScoreReqMin {get; set;}
[Column(name:"PassNPTest22HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest22HiScoreReqPass {get; set;}
[Column(name:"PassNPTest22HiScoreScore")]
[StringLength(4)]
public string PassNPTest22HiScoreScore {get; set;}
[Column(name:"PassNPTest23HiScoreCode")]
[StringLength(4)]
public string PassNPTest23HiScoreCode {get; set;}
[Column(name:"PassNPTest23HiScoreDate")]
[StringLength(10)]
public string PassNPTest23HiScoreDate {get; set;}
[Column(name:"PassNPTest23HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest23HiScoreMetNM {get; set;}
[Column(name:"PassNPTest23HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest23HiScorePassedNP {get; set;}
[Column(name:"PassNPTest23HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest23HiScoreReqMin {get; set;}
[Column(name:"PassNPTest23HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest23HiScoreReqPass {get; set;}
[Column(name:"PassNPTest23HiScoreScore")]
[StringLength(4)]
public string PassNPTest23HiScoreScore {get; set;}
[Column(name:"PassNPTest24HiScoreCode")]
[StringLength(4)]
public string PassNPTest24HiScoreCode {get; set;}
[Column(name:"PassNPTest24HiScoreDate")]
[StringLength(10)]
public string PassNPTest24HiScoreDate {get; set;}
[Column(name:"PassNPTest24HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest24HiScoreMetNM {get; set;}
[Column(name:"PassNPTest24HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest24HiScorePassedNP {get; set;}
[Column(name:"PassNPTest24HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest24HiScoreReqMin {get; set;}
[Column(name:"PassNPTest24HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest24HiScoreReqPass {get; set;}
[Column(name:"PassNPTest24HiScoreScore")]
[StringLength(4)]
public string PassNPTest24HiScoreScore {get; set;}
[Column(name:"PassNPTest25HiScoreCode")]
[StringLength(4)]
public string PassNPTest25HiScoreCode {get; set;}
[Column(name:"PassNPTest25HiScoreDate")]
[StringLength(10)]
public string PassNPTest25HiScoreDate {get; set;}
[Column(name:"PassNPTest25HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest25HiScoreMetNM {get; set;}
[Column(name:"PassNPTest25HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest25HiScorePassedNP {get; set;}
[Column(name:"PassNPTest25HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest25HiScoreReqMin {get; set;}
[Column(name:"PassNPTest25HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest25HiScoreReqPass {get; set;}
[Column(name:"PassNPTest25HiScoreScore")]
[StringLength(4)]
public string PassNPTest25HiScoreScore {get; set;}
[Column(name:"PassNPTest26HiScoreCode")]
[StringLength(4)]
public string PassNPTest26HiScoreCode {get; set;}
[Column(name:"PassNPTest26HiScoreDate")]
[StringLength(10)]
public string PassNPTest26HiScoreDate {get; set;}
[Column(name:"PassNPTest26HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest26HiScoreMetNM {get; set;}
[Column(name:"PassNPTest26HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest26HiScorePassedNP {get; set;}
[Column(name:"PassNPTest26HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest26HiScoreReqMin {get; set;}
[Column(name:"PassNPTest26HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest26HiScoreReqPass {get; set;}
[Column(name:"PassNPTest26HiScoreScore")]
[StringLength(4)]
public string PassNPTest26HiScoreScore {get; set;}
[Column(name:"PassNPTest27HiScoreCode")]
[StringLength(4)]
public string PassNPTest27HiScoreCode {get; set;}
[Column(name:"PassNPTest27HiScoreDate")]
[StringLength(10)]
public string PassNPTest27HiScoreDate {get; set;}
[Column(name:"PassNPTest27HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest27HiScoreMetNM {get; set;}
[Column(name:"PassNPTest27HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest27HiScorePassedNP {get; set;}
[Column(name:"PassNPTest27HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest27HiScoreReqMin {get; set;}
[Column(name:"PassNPTest27HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest27HiScoreReqPass {get; set;}
[Column(name:"PassNPTest27HiScoreScore")]
[StringLength(4)]
public string PassNPTest27HiScoreScore {get; set;}
[Column(name:"PassNPTest28HiScoreCode")]
[StringLength(4)]
public string PassNPTest28HiScoreCode {get; set;}
[Column(name:"PassNPTest28HiScoreDate")]
[StringLength(10)]
public string PassNPTest28HiScoreDate {get; set;}
[Column(name:"PassNPTest28HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest28HiScoreMetNM {get; set;}
[Column(name:"PassNPTest28HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest28HiScorePassedNP {get; set;}
[Column(name:"PassNPTest28HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest28HiScoreReqMin {get; set;}
[Column(name:"PassNPTest28HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest28HiScoreReqPass {get; set;}
[Column(name:"PassNPTest28HiScoreScore")]
[StringLength(4)]
public string PassNPTest28HiScoreScore {get; set;}
[Column(name:"PassNPTest29HiScoreCode")]
[StringLength(4)]
public string PassNPTest29HiScoreCode {get; set;}
[Column(name:"PassNPTest29HiScoreDate")]
[StringLength(10)]
public string PassNPTest29HiScoreDate {get; set;}
[Column(name:"PassNPTest29HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest29HiScoreMetNM {get; set;}
[Column(name:"PassNPTest29HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest29HiScorePassedNP {get; set;}
[Column(name:"PassNPTest29HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest29HiScoreReqMin {get; set;}
[Column(name:"PassNPTest29HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest29HiScoreReqPass {get; set;}
[Column(name:"PassNPTest29HiScoreScore")]
[StringLength(4)]
public string PassNPTest29HiScoreScore {get; set;}
[Column(name:"PassNPTest2HiScoreCode")]
[StringLength(4)]
public string PassNPTest2HiScoreCode {get; set;}
[Column(name:"PassNPTest2HiScoreDate")]
[StringLength(10)]
public string PassNPTest2HiScoreDate {get; set;}
[Column(name:"PassNPTest2HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest2HiScoreMetNM {get; set;}
[Column(name:"PassNPTest2HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest2HiScorePassedNP {get; set;}
[Column(name:"PassNPTest2HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest2HiScoreReqMin {get; set;}
[Column(name:"PassNPTest2HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest2HiScoreReqPass {get; set;}
[Column(name:"PassNPTest2HiScoreScore")]
[StringLength(4)]
public string PassNPTest2HiScoreScore {get; set;}
[Column(name:"PassNPTest30HiScoreCode")]
[StringLength(4)]
public string PassNPTest30HiScoreCode {get; set;}
[Column(name:"PassNPTest30HiScoreDate")]
[StringLength(10)]
public string PassNPTest30HiScoreDate {get; set;}
[Column(name:"PassNPTest30HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest30HiScoreMetNM {get; set;}
[Column(name:"PassNPTest30HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest30HiScorePassedNP {get; set;}
[Column(name:"PassNPTest30HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest30HiScoreReqMin {get; set;}
[Column(name:"PassNPTest30HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest30HiScoreReqPass {get; set;}
[Column(name:"PassNPTest30HiScoreScore")]
[StringLength(4)]
public string PassNPTest30HiScoreScore {get; set;}
[Column(name:"PassNPTest31HiScoreCode")]
[StringLength(4)]
public string PassNPTest31HiScoreCode {get; set;}
[Column(name:"PassNPTest31HiScoreDate")]
[StringLength(10)]
public string PassNPTest31HiScoreDate {get; set;}
[Column(name:"PassNPTest31HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest31HiScoreMetNM {get; set;}
[Column(name:"PassNPTest31HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest31HiScorePassedNP {get; set;}
[Column(name:"PassNPTest31HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest31HiScoreReqMin {get; set;}
[Column(name:"PassNPTest31HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest31HiScoreReqPass {get; set;}
[Column(name:"PassNPTest31HiScoreScore")]
[StringLength(4)]
public string PassNPTest31HiScoreScore {get; set;}
[Column(name:"PassNPTest32HiScoreCode")]
[StringLength(4)]
public string PassNPTest32HiScoreCode {get; set;}
[Column(name:"PassNPTest32HiScoreDate")]
[StringLength(10)]
public string PassNPTest32HiScoreDate {get; set;}
[Column(name:"PassNPTest32HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest32HiScoreMetNM {get; set;}
[Column(name:"PassNPTest32HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest32HiScorePassedNP {get; set;}
[Column(name:"PassNPTest32HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest32HiScoreReqMin {get; set;}
[Column(name:"PassNPTest32HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest32HiScoreReqPass {get; set;}
[Column(name:"PassNPTest32HiScoreScore")]
[StringLength(4)]
public string PassNPTest32HiScoreScore {get; set;}
[Column(name:"PassNPTest33HiScoreCode")]
[StringLength(4)]
public string PassNPTest33HiScoreCode {get; set;}
[Column(name:"PassNPTest33HiScoreDate")]
[StringLength(10)]
public string PassNPTest33HiScoreDate {get; set;}
[Column(name:"PassNPTest33HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest33HiScoreMetNM {get; set;}
[Column(name:"PassNPTest33HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest33HiScorePassedNP {get; set;}
[Column(name:"PassNPTest33HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest33HiScoreReqMin {get; set;}
[Column(name:"PassNPTest33HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest33HiScoreReqPass {get; set;}
[Column(name:"PassNPTest33HiScoreScore")]
[StringLength(4)]
public string PassNPTest33HiScoreScore {get; set;}
[Column(name:"PassNPTest34HiScoreCode")]
[StringLength(4)]
public string PassNPTest34HiScoreCode {get; set;}
[Column(name:"PassNPTest34HiScoreDate")]
[StringLength(10)]
public string PassNPTest34HiScoreDate {get; set;}
[Column(name:"PassNPTest34HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest34HiScoreMetNM {get; set;}
[Column(name:"PassNPTest34HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest34HiScorePassedNP {get; set;}
[Column(name:"PassNPTest34HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest34HiScoreReqMin {get; set;}
[Column(name:"PassNPTest34HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest34HiScoreReqPass {get; set;}
[Column(name:"PassNPTest34HiScoreScore")]
[StringLength(4)]
public string PassNPTest34HiScoreScore {get; set;}
[Column(name:"PassNPTest35HiScoreCode")]
[StringLength(4)]
public string PassNPTest35HiScoreCode {get; set;}
[Column(name:"PassNPTest35HiScoreDate")]
[StringLength(10)]
public string PassNPTest35HiScoreDate {get; set;}
[Column(name:"PassNPTest35HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest35HiScoreMetNM {get; set;}
[Column(name:"PassNPTest35HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest35HiScorePassedNP {get; set;}
[Column(name:"PassNPTest35HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest35HiScoreReqMin {get; set;}
[Column(name:"PassNPTest35HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest35HiScoreReqPass {get; set;}
[Column(name:"PassNPTest35HiScoreScore")]
[StringLength(4)]
public string PassNPTest35HiScoreScore {get; set;}
[Column(name:"PassNPTest36HiScoreCode")]
[StringLength(4)]
public string PassNPTest36HiScoreCode {get; set;}
[Column(name:"PassNPTest36HiScoreDate")]
[StringLength(10)]
public string PassNPTest36HiScoreDate {get; set;}
[Column(name:"PassNPTest36HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest36HiScoreMetNM {get; set;}
[Column(name:"PassNPTest36HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest36HiScorePassedNP {get; set;}
[Column(name:"PassNPTest36HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest36HiScoreReqMin {get; set;}
[Column(name:"PassNPTest36HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest36HiScoreReqPass {get; set;}
[Column(name:"PassNPTest36HiScoreScore")]
[StringLength(4)]
public string PassNPTest36HiScoreScore {get; set;}
[Column(name:"PassNPTest3HiScoreCode")]
[StringLength(4)]
public string PassNPTest3HiScoreCode {get; set;}
[Column(name:"PassNPTest3HiScoreDate")]
[StringLength(10)]
public string PassNPTest3HiScoreDate {get; set;}
[Column(name:"PassNPTest3HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest3HiScoreMetNM {get; set;}
[Column(name:"PassNPTest3HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest3HiScorePassedNP {get; set;}
[Column(name:"PassNPTest3HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest3HiScoreReqMin {get; set;}
[Column(name:"PassNPTest3HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest3HiScoreReqPass {get; set;}
[Column(name:"PassNPTest3HiScoreScore")]
[StringLength(4)]
public string PassNPTest3HiScoreScore {get; set;}
[Column(name:"PassNPTest4HiScoreCode")]
[StringLength(4)]
public string PassNPTest4HiScoreCode {get; set;}
[Column(name:"PassNPTest4HiScoreDate")]
[StringLength(10)]
public string PassNPTest4HiScoreDate {get; set;}
[Column(name:"PassNPTest4HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest4HiScoreMetNM {get; set;}
[Column(name:"PassNPTest4HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest4HiScorePassedNP {get; set;}
[Column(name:"PassNPTest4HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest4HiScoreReqMin {get; set;}
[Column(name:"PassNPTest4HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest4HiScoreReqPass {get; set;}
[Column(name:"PassNPTest4HiScoreScore")]
[StringLength(4)]
public string PassNPTest4HiScoreScore {get; set;}
[Column(name:"PassNPTest5HiScoreCode")]
[StringLength(4)]
public string PassNPTest5HiScoreCode {get; set;}
[Column(name:"PassNPTest5HiScoreDate")]
[StringLength(10)]
public string PassNPTest5HiScoreDate {get; set;}
[Column(name:"PassNPTest5HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest5HiScoreMetNM {get; set;}
[Column(name:"PassNPTest5HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest5HiScorePassedNP {get; set;}
[Column(name:"PassNPTest5HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest5HiScoreReqMin {get; set;}
[Column(name:"PassNPTest5HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest5HiScoreReqPass {get; set;}
[Column(name:"PassNPTest5HiScoreScore")]
[StringLength(4)]
public string PassNPTest5HiScoreScore {get; set;}
[Column(name:"PassNPTest6HiScoreCode")]
[StringLength(4)]
public string PassNPTest6HiScoreCode {get; set;}
[Column(name:"PassNPTest6HiScoreDate")]
[StringLength(10)]
public string PassNPTest6HiScoreDate {get; set;}
[Column(name:"PassNPTest6HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest6HiScoreMetNM {get; set;}
[Column(name:"PassNPTest6HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest6HiScorePassedNP {get; set;}
[Column(name:"PassNPTest6HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest6HiScoreReqMin {get; set;}
[Column(name:"PassNPTest6HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest6HiScoreReqPass {get; set;}
[Column(name:"PassNPTest6HiScoreScore")]
[StringLength(4)]
public string PassNPTest6HiScoreScore {get; set;}
[Column(name:"PassNPTest7HiScoreCode")]
[StringLength(4)]
public string PassNPTest7HiScoreCode {get; set;}
[Column(name:"PassNPTest7HiScoreDate")]
[StringLength(10)]
public string PassNPTest7HiScoreDate {get; set;}
[Column(name:"PassNPTest7HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest7HiScoreMetNM {get; set;}
[Column(name:"PassNPTest7HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest7HiScorePassedNP {get; set;}
[Column(name:"PassNPTest7HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest7HiScoreReqMin {get; set;}
[Column(name:"PassNPTest7HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest7HiScoreReqPass {get; set;}
[Column(name:"PassNPTest7HiScoreScore")]
[StringLength(4)]
public string PassNPTest7HiScoreScore {get; set;}
[Column(name:"PassNPTest8HiScoreCode")]
[StringLength(4)]
public string PassNPTest8HiScoreCode {get; set;}
[Column(name:"PassNPTest8HiScoreDate")]
[StringLength(10)]
public string PassNPTest8HiScoreDate {get; set;}
[Column(name:"PassNPTest8HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest8HiScoreMetNM {get; set;}
[Column(name:"PassNPTest8HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest8HiScorePassedNP {get; set;}
[Column(name:"PassNPTest8HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest8HiScoreReqMin {get; set;}
[Column(name:"PassNPTest8HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest8HiScoreReqPass {get; set;}
[Column(name:"PassNPTest8HiScoreScore")]
[StringLength(4)]
public string PassNPTest8HiScoreScore {get; set;}
[Column(name:"PassNPTest9HiScoreCode")]
[StringLength(4)]
public string PassNPTest9HiScoreCode {get; set;}
[Column(name:"PassNPTest9HiScoreDate")]
[StringLength(10)]
public string PassNPTest9HiScoreDate {get; set;}
[Column(name:"PassNPTest9HiScoreMetNM")]
[StringLength(7)]
public string PassNPTest9HiScoreMetNM {get; set;}
[Column(name:"PassNPTest9HiScorePassedNP")]
[StringLength(10)]
public string PassNPTest9HiScorePassedNP {get; set;}
[Column(name:"PassNPTest9HiScoreReqMin")]
[StringLength(3)]
public string PassNPTest9HiScoreReqMin {get; set;}
[Column(name:"PassNPTest9HiScoreReqPass")]
[StringLength(4)]
public string PassNPTest9HiScoreReqPass {get; set;}
[Column(name:"PassNPTest9HiScoreScore")]
[StringLength(4)]
public string PassNPTest9HiScoreScore {get; set;}
[Column(name:"ProgramIdentifier")]
[StringLength(6)]
public string ProgramIdentifier {get; set;}
[Column(name:"RecipientCode")]
[StringLength(4)]
public string RecipientCode {get; set;}
[Column(name:"Sex")]
[StringLength(1)]
public string Sex {get; set;}
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Column(name:"State")]
[StringLength(2)]
public string State {get; set;}
[Column(name:"StateCode")]
[StringLength(2)]
public string StateCode {get; set;}
[Column(name:"UndergradGPA")]
[StringLength(3)]
public string UndergradGPA {get; set;}
[Column(name:"UndergradMajor")]
[StringLength(3)]
public string UndergradMajor {get; set;}
[Required]
[Column(name:"UniqueRecNum")]
[StringLength(1)]
public string UniqueRecNum {get; set;}
[Column(name:"Zip")]
[StringLength(9)]
public string Zip {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
