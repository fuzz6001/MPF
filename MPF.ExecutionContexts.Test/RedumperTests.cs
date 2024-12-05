using MPF.ExecutionContexts.Redumper;
using SabreTools.RedumpLib.Data;
using Xunit;

namespace MPF.ExecutionContexts.Test
{
    public class RedumperTests
    {
        #region Converters.Extension

        [Theory]
        [InlineData(null, null)]
        [InlineData(MediaType.CDROM, ".bin")]
        [InlineData(MediaType.GDROM, null)]
        [InlineData(MediaType.DVD, ".iso")]
        [InlineData(MediaType.HDDVD, ".iso")]
        [InlineData(MediaType.BluRay, ".iso")]
        [InlineData(MediaType.FloppyDisk, null)]
        [InlineData(MediaType.HardDisk, null)]
        [InlineData(MediaType.ApertureCard,null)]
        public void ExtensionTest(MediaType? type, string? expected)
        {
            string? actual = Converters.Extension(type);
            Assert.Equal(expected, actual);
        }

        #endregion
    
        #region CD

        [Theory]
        [InlineData("cd -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("cd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void CDTest(string parameters)
        {
            string? expected = "cd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region DVD

        [Theory]
        [InlineData("dvd -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("dvd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void DVDTest(string parameters)
        {
            string? expected = "dvd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region BD

        [Theory]
        [InlineData("bd -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("bd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void BDTest(string parameters)
        {
            string? expected = "bd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region SACD

        [Theory]
        [InlineData("sacd -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("sacd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void SACDTest(string parameters)
        {
            string? expected = "sacd --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region New

        [Theory]
        [InlineData("new -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("new --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void NewTest(string parameters)
        {
            string? expected = "new --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Rings

        [Theory]
        [InlineData("rings -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("rings --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void RingsTest(string parameters)
        {
            string? expected = "rings --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Dump

        [Theory]
        [InlineData("dump -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("dump --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void DumpTest(string parameters)
        {
            string? expected = "dump --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region DumpNew

        [Theory]
        [InlineData("dumpnew -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("dumpnew --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void DumpNewTest(string parameters)
        {
            string? expected = "dumpnew --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Refine

        [Theory]
        [InlineData("refine -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("refine --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void RefineTest(string parameters)
        {
            string? expected = "refine --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region RefineNew

        [Theory]
        [InlineData("refinenew -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("refinenew --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void RefineNewTest(string parameters)
        {
            string? expected = "refinenew --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Verify

        [Theory]
        [InlineData("verify -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("verify --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void VerifyTest(string parameters)
        {
            string? expected = "verify --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region DVDKey

        [Theory]
        [InlineData("dvdkey -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("dvdkey --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void DVDKeyTest(string parameters)
        {
            string? expected = "dvdkey --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Eject

        [Theory]
        [InlineData("eject -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("eject --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void EjectTest(string parameters)
        {
            string? expected = "eject --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region DVDIsoKey

        [Theory]
        [InlineData("dvdisokey -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("dvdisokey --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void DVDIsoKeyTest(string parameters)
        {
            string? expected = "dvdisokey --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Protection

        [Theory]
        [InlineData("protection -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("protection --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void ProtectionTest(string parameters)
        {
            string? expected = "protection --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Split

        [Theory]
        [InlineData("split -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("split --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void SplitTest(string parameters)
        {
            string? expected = "split --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Hash

        [Theory]
        [InlineData("hash -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("hash --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void HashTest(string parameters)
        {
            string? expected = "hash --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Info

        [Theory]
        [InlineData("info -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("info --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void InfoTest(string parameters)
        {
            string? expected = "info --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Skeleton

        [Theory]
        [InlineData("skeleton -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("skeleton --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void SkeletonTest(string parameters)
        {
            string? expected = "skeleton --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Debug

        [Theory]
        [InlineData("debug -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        [InlineData("debug --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        public void DebugTest(string parameters)
        {
            string? expected = "debug --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
            var context = new ExecutionContext(parameters);
            string? actual = context.GenerateParameters();
            Assert.Equal(expected, actual);
        }

        #endregion

        // Currently disabled
        #region FixMSF

        // [Theory]
        // [InlineData("fixmsf -h --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        // [InlineData("fixmsf --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=path --image-name=image --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext")]
        // public void FixMSFTest(string parameters)
        // {
        //     string? expected = "fixmsf --help --version --verbose --auto-eject --drive=dr --speed=0 --retries=0 --image-path=\"path\" --image-name=\"image\" --overwrite --drive-type=dt --drive-read-offset=0 --drive-c2-shift=0 --drive-pregap-start=0 --drive-read-method=drm --drive-sector-order=dso --plextor-skip-leadin --plextor-leadin-retries=0 --asus-skip-leadout --force-offset=0 --audio-silence-threshold=0 --correct-offset-shift --offset-shift-relocate --force-split --leave-unchanged --force-qtoc --skip-fill=0 --iso9660-trim --lba-start=0 --lba-end=0 --refine-subchannel --skip=0 --dump-write-offset=0 --dump-read-size=0 --overread-leadout --force-unscrambled --legacy-subs --disable-cdtext";
        //     var context = new ExecutionContext(parameters);
        //     string? actual = context.GenerateParameters();
        //     Assert.Equal(expected, actual);
        // }

        #endregion
    }
}